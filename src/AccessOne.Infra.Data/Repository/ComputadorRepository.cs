using AccessOne.Domain.Interfaces;
using AccessOne.Domain.Models;
using AccessOne.Infra.Data.Context;

namespace AccessOne.Infra.Data.Repository
{
    public class ComputadorRepository : Repository<Computador>, IComputadorRepository
    {
        public ComputadorRepository(AccessOneContext context)
            : base(context)
        {

        }
    }
}
