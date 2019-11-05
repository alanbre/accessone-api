using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccessOne.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        Task<List<TEntity>> SelectAsync();
        Task<TEntity> SelectAsync(Guid id);
        Task<TEntity> InsertAsync(TEntity obj);

        Task<TEntity> UpdateAsync(TEntity obj);

        Task<bool> DeleteAsync(Guid id);


    }
}

