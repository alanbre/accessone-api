using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccessOne.Domain.Models;
using AccessOne.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace AccessOne.Infra.Data.Repository
{
    public class ComandoRepository<T> : Repository<Comando>
    {
        public ComandoRepository(AccessOneContext context)
            : base(context)
        {
        }

        public async Task<List<Comando>> SelectByComputadorAsync(Guid computadorId)
        {
            return await DbSet.AsNoTracking().Where(c => c.ComputadorId == computadorId).ToListAsync();
        }
    }
}
