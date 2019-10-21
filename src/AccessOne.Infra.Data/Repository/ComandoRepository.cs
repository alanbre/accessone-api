using AccessOne.Domain.Models;
using AccessOne.Infra.Data.Context;

namespace AccessOne.Infra.Data.Repository
{
    public class ComandoRepository<T> : BaseRepository<Comando>
    {
        public ComandoRepository(AccessOneContext context)
            : base(context)
        {
        }
    }
}
