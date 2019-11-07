using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccessOne.Domain.Interfaces;
using AccessOne.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace AccessOne.Infra.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly AccessOneContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(AccessOneContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public virtual async Task<List<TEntity>> SelectAsync()
        {
            return await DbSet.AsNoTracking().ToListAsync();
        }

        public virtual async Task<TEntity> SelectAsync(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public virtual async Task<TEntity> InsertAsync(TEntity obj)
        {
            await DbSet.AddAsync(obj);
            await Db.SaveChangesAsync();
            return obj;
        }

        public virtual async Task<TEntity> UpdateAsync(TEntity obj)
        {
            DbSet.Update(obj);
            await Db.SaveChangesAsync();
            return obj;
        }

        public virtual async Task<bool> DeleteAsync(Guid id)
        {
            var obj = await SelectAsync(id);
            if(obj == null) return false;

            DbSet.Remove(obj);
            return await Db.SaveChangesAsync() > 0;
        }
        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
