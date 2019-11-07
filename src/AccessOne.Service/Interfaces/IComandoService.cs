using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AccessOne.Domain.Models;

namespace AccessOne.Service.Interfaces
{
    public interface IComandoService : IDisposable
    {
        Task<List<Comando>> SelectByComputador(Guid computadorId);
        Task<Comando> InsertAsync(Comando comando);
        Task<Comando> UpdateAsync(Comando comando);
    }
}