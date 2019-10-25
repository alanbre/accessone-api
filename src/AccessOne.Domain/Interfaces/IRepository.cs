using AccessOne.Domain.Core.Models;
using System;
using System.Linq;

namespace AccessOne.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Insert(TEntity obj);

        void Update(TEntity obj);

        void Delete(Guid id);

        TEntity Select(Guid id);

        IQueryable<TEntity> Select();
    }
}

