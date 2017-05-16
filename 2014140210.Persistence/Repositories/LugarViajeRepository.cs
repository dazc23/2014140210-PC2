namespace _2014140210.Persistence.Repositories
{
    internal class LugarViajeRepository
    {
        private TransporteDbContext _Context;

        public LugarViajeRepository(TransporteDbContext _Context)
        {
            this._Context = _Context;
        }
    }
}