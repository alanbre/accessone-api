using AccessOne.Domain.Models;
using AccessOne.Infra.Data.Context;
using AccessOne.Domain.Interfaces;

namespace AccessOne.Infra.Data.Repository
{
    public class GrupoRepository : Repository<Grupo>, IGrupoRepository
    {
        public GrupoRepository(AccessOneContext context)
            : base(context)
        {

        }
    }
}
