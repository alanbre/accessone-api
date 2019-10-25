using AccessOne.Domain.Models;
using AccessOne.Infra.Data.Context;

namespace AccessOne.Infra.Data.Repository
{
    public class ComandoRepository<T> : Repository<Comando>
    {
        public ComandoRepository(AccessOneContext context)
            : base(context)
        {
        }
    }
}
