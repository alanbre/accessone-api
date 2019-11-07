using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AccessOne.Domain.Models;

namespace AccessOne.Domain.Interfaces
{
    public interface IComandoRepository : IRepository<Comando>
    {
         Task<List<Comando>> SelectByComputadorAsync(Guid computadorId);
    }
}