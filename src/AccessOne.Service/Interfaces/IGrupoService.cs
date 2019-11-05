using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AccessOne.Domain.Models;

namespace AccessOne.Service.Interfaces
{
    public interface IGrupoService : IDisposable
    {
        Task<List<Grupo>> SelectAsync();
        Task<Grupo> SelectAsync(Guid id);
        Task<Grupo> InsertAsync(Grupo grupo);
        Task<Grupo> UpdateAsync(Grupo grupo);
        Task<bool> DeleteAsync(Guid id);
    }
}