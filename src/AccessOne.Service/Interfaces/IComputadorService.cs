using AccessOne.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccessOne.Service.Interfaces
{
    public interface IComputadorService : IDisposable
    {
        Task<List<Computador>> SelectAsync();
        Task<Computador> SelectAsync(Guid id);
        Task<Computador> InsertAsync(Computador computador);
        Task<Computador> UpdateAsync(Computador computador);
        Task<bool> DeleteAsync(Guid id);
        Task<bool> Exists(Guid id);
    }
}
