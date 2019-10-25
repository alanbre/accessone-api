using AccessOne.Domain.Interfaces;
using AccessOne.Infra.Data.Context;

namespace AccessOne.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AccessOneContext _context;

        public UnitOfWork(AccessOneContext context)
        {
            _context = context;
        }

        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
