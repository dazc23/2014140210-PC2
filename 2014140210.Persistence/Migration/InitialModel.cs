using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014140210.Persistence.Migration
{
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bus",
                c => new
                {
                    NroPlaca = c.Int(nullable: false, identity: true),
                    Modelo = c.String(),
                    Color = c.String(),
                    Kilometraje = c.Int(nullable: false),
                    Tripulacion_ListaTripulacion = c.Int(),
                })
                .PrimaryKey(t => t.NroPlaca)
                .ForeignKey("dbo.Servicios", t => t.Tripulacion_ListaTripulacion)
                .Index(t => t.Tripulacion_ListaTripulacion);

            CreateTable(
                "dbo.Servicio",
                c => new
                {
                    ServicioId = c.Int(nullable: false, identity: true),
                    FechaPartida= c.String(),
                    CalcularServicio = c.Decimal(nullable: false, precision: 18, scale: 2),
                    FechaLlegada = c.String(),
                })
                .PrimaryKey(t => t.ServicioId)
                .ForeignKey("dbo.Bus", t => t.NroPlaca, cascadeDelete: true)
                .ForeignKey("dbo.Venta", t => t.VentaId, cascadeDelete: true)
                .Index(t => t.VentaId)
                .Index(t => t.NroPlaca);

            CreateTable(
                "dbo.LugarViaje",
                c => new
                {
                    LugarViajeId = c.Int(nullable: false, identity: true),
                    NombreLugar = c.String(),
                    TransporteId = c.Int(nullable: false),
                    EncomiendaId = c.Int(nullable: false),
                    BusId = c.Int(nullable: false),
                    Encomienda_ServicioId = c.Int(),
                    Transporte_ServicioId = c.Int(),
                })
                .PrimaryKey(t => t.LugarViajeId)
                .ForeignKey("dbo.Bus", t => t.BusId, cascadeDelete: true)
                .ForeignKey("dbo.Servicio", t => t.Encomienda_ServicioId)
                .ForeignKey("dbo.Servicio", t => t.Transporte_ServicioId)
                .Index(t => t.BusId)
                .Index(t => t.Encomienda_ServicioId)
                .Index(t => t.Transporte_ServicioId);

            CreateTable(
                "dbo.TipoLugar",
                c => new
                {
                    TipoLugarId = c.Int(nullable: false, identity: true),
                    NombreTipo = c.String(),
                    LugarViajeId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.TipoLugarId)
                .ForeignKey("dbo.LugarViaje", t => t.LugarViajeId, cascadeDelete: true)
                .Index(t => t.LugarViajeId);

            CreateTable(
                "dbo.Cliente",
                c => new
                {
                    ClienteId = c.Int(nullable: false, identity: true),
                    Nombre = c.String(),
                    Apellidos = c.String(),
                    DNI = c.String(),
                    VentaId = c.Int(nullable: false),
                    TransporteId = c.Int(nullable: false),
                    Transporte_ServicioId = c.Int(),
                })
                .PrimaryKey(t => t.ClienteId)
                .ForeignKey("dbo.Servicio", t => t.Transporte_ServicioId)
                .ForeignKey("dbo.Venta", t => t.VentaId, cascadeDelete: true)
                .Index(t => t.VentaId)
                .Index(t => t.Transporte_ServicioId);

            CreateTable(
                "dbo.Venta",
                c => new
                {
                    VentaId = c.Int(nullable: false, identity: true),
                    Fecha = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.VentaId);

            CreateTable(
                "dbo.Empleado",
                c => new
                {
                    EmpleadoId = c.Int(nullable: false, identity: true),
                    Nombre = c.String(),
                    Apellidos = c.String(),
                    DNI = c.String(),
                    Edad = c.Int(nullable: false),
                    Sueldo = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Cargo = c.String(),
                    VentaId = c.Int(),
                    BusId = c.Int(),
                    Discriminator = c.String(nullable: false, maxLength: 128),
                })
                .PrimaryKey(t => t.EmpleadoId)
                .ForeignKey("dbo.Venta", t => t.VentaId, cascadeDelete: true)
                .ForeignKey("dbo.Bus", t => t.BusId, cascadeDelete: true)
                .Index(t => t.VentaId)
                .Index(t => t.BusId);

            CreateTable(
                "dbo.TipoComprobante",
                c => new
                {
                    TipoComprobanteId = c.Int(nullable: false, identity: true),
                    NombreComprobante = c.String(),
                    VentaId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.TipoComprobanteId)
                .ForeignKey("dbo.Venta", t => t.VentaId, cascadeDelete: true)
                .Index(t => t.VentaId);

            CreateTable(
                "dbo.TipoPago",
                c => new
                {
                    TipoPagoId = c.Int(nullable: false, identity: true),
                    MetodoPago = c.String(),
                    VentaId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.TipoPagoId)
                .ForeignKey("dbo.Ventas", t => t.VentaId, cascadeDelete: true)
                .Index(t => t.VentaId);

            CreateTable(
                "dbo.TipoViaje",
                c => new
                {
                    TipoViajeId = c.Int(nullable: false, identity: true),
                    Nombre = c.String(),
                    TransporteId = c.Int(nullable: false),
                    Transporte_ServicioId = c.Int(),
                })
                .PrimaryKey(t => t.TipoViajeId)
                .ForeignKey("dbo.Servicio", t => t.Transporte_ServicioId)
                .Index(t => t.Transporte_ServicioId);

            CreateTable(
                "dbo.TipoTripulacion",
                c => new
                {
                    TipoTripulacionId = c.Int(nullable: false, identity: true),
                    Nombre = c.String(),
                    TripulacionId = c.Int(nullable: false),
                    Tripulacion_EmpleadoId = c.Int(),
                })
                .PrimaryKey(t => t.TipoTripulacionId)
                .ForeignKey("dbo.Empleadoes", t => t.Tripulacion_EmpleadoId)
                .Index(t => t.Tripulacion_EmpleadoId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.TipoTripulacion", "Tripulacion_EmpleadoId", "dbo.Empleado");
            DropForeignKey("dbo.Empleado", "NroPlaca", "dbo.Bus");
            DropForeignKey("dbo.TipoViaje", "Transporte_ServicioId", "dbo.Servicio");
            DropForeignKey("dbo.LugarViaje", "Transporte_ServicioId", "dbo.Servicio");
            DropForeignKey("dbo.TipoPago", "VentaId", "dbo.Venta");
            DropForeignKey("dbo.TipoComprobante", "VentaId", "dbo.Venta");
            DropForeignKey("dbo.Servicio", "VentaId", "dbo.Venta");
            DropForeignKey("dbo.Cliente", "VentaId", "dbo.Venta");
            DropForeignKey("dbo.Empleado", "VentaId", "dbo.Venta");
            DropForeignKey("dbo.Cliente", "Transporte_ServicioId", "dbo.Servicio");
            DropForeignKey("dbo.Bus", "Transporte_ServicioId", "dbo.Servicio");
            DropForeignKey("dbo.TipoLugar", "LugarViajeId", "dbo.LugarViaje");
            DropForeignKey("dbo.LugarViaje", "Encomienda_ServicioId", "dbo.Servicio");
            DropForeignKey("dbo.LugarViaje", "NroPlaca", "dbo.Bus");
            DropForeignKey("dbo.Servicio", "NroPlaca", "dbo.Bus");
            DropIndex("dbo.TipoTripulacion", new[] { "Tripulacion_EmpleadoId" });
            DropIndex("dbo.TipoViaje", new[] { "Transporte_ServicioId" });
            DropIndex("dbo.TipoPago", new[] { "VentaId" });
            DropIndex("dbo.TipoComprobante", new[] { "VentaId" });
            DropIndex("dbo.Empleado", new[] { "NroPlaca" });
            DropIndex("dbo.Empleado", new[] { "VentaId" });
            DropIndex("dbo.Cliente", new[] { "Transporte_ServicioId" });
            DropIndex("dbo.Cliente", new[] { "VentaId" });
            DropIndex("dbo.TipoLugar", new[] { "LugarViajeId" });
            DropIndex("dbo.LugarViaje", new[] { "Transporte_ServicioId" });
            DropIndex("dbo.LugarViaje", new[] { "Encomienda_ServicioId" });
            DropIndex("dbo.LugarViaje", new[] { "BusId" });
            DropIndex("dbo.Servicio", new[] { "BusId" });
            DropIndex("dbo.Servicio", new[] { "VentaId" });
            DropIndex("dbo.Buses", new[] { "Transporte_ServicioId" });
            DropTable("dbo.TipoTripulacion");
            DropTable("dbo.TipoViaje");
            DropTable("dbo.TipoPago");
            DropTable("dbo.TipoComprobante");
            DropTable("dbo.Empleado");
            DropTable("dbo.Venta");
            DropTable("dbo.Cliente");
            DropTable("dbo.TipoLugar");
            DropTable("dbo.LugarViaje");
            DropTable("dbo.Servicio");
            DropTable("dbo.Bus");
        
        }
    }
    }


