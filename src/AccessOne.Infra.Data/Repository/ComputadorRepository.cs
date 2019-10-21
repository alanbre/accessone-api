using AccessOne.Domain.Models;
using AccessOne.Infra.Data.Context;

namespace AccessOne.Infra.Data.Repository
{
    public class ComputadorRepository<T> : BaseRepository<Computador>
    {
        public ComputadorRepository(AccessOneContext context)
            : base(context)
        {

        }
    }
}
