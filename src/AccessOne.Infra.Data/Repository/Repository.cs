using System;
using System.Linq;
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

        public virtual void Insert(TEntity obj)
        {
            DbSet.Add(obj);
        }

        public void Update(TEntity obj)
        {
            DbSet.Update(obj);
        }

        public void Delete(Guid id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public IQueryable<TEntity> Select()
        {
            return DbSet;
        }

        public virtual TEntity Select(Guid id)
        {
            return DbSet.Find(id);
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
