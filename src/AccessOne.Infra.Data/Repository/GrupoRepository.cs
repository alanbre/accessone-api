using AccessOne.Domain.Models;
using AccessOne.Infra.Data.Context;

namespace AccessOne.Infra.Data.Repository
{
    public class GrupoRepository<T> : Repository<Grupo>
    {
        public GrupoRepository(AccessOneContext context)
            : base(context)
        {

        }
    }
}
