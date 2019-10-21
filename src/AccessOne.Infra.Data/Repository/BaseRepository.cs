using AccessOne.Domain.Models;
using AccessOne.Domain.Interfaces;
using AccessOne.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AccessOne.Infra.Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : Entity
    {
        protected readonly AccessOneContext Db;
        protected readonly DbSet<T> DbSet;

        public BaseRepository(AccessOneContext context)
        {
            Db = context;
            DbSet = Db.Set<T>();
        }

        public virtual void Insert(T obj)
        {
            DbSet.Add(obj);
            Db.SaveChanges();
        }

        public void Update(T obj)
        {
            DbSet.Update(obj);
            Db.SaveChanges();
        }

        public void Delete(int id)
        {
            Db.Remove(Select(id));
            Db.SaveChanges();
        }

        public IList<T> Select()
        {
            return Db.Set<T>().ToList();
        }

        public T Select(int id)
        {
            return DbSet.Find(id);
        }
    }
}
