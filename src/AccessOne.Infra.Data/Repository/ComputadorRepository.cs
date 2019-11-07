using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AccessOne.Domain.Interfaces;
using AccessOne.Domain.Models;
using AccessOne.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace AccessOne.Infra.Data.Repository
{
    public class ComputadorRepository : Repository<Computador>, IComputadorRepository
    {
        public ComputadorRepository(AccessOneContext context)
            : base(context)
        {
            
        }

        public override async Task<List<Computador>> SelectAsync()
        {
            return await DbSet.Include(c => c.Grupo).AsNoTracking().ToListAsync();
        }

        public override async Task<Computador> SelectAsync(Guid id)
        {
            return await DbSet.Include(c => c.Grupo).AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
