using AccessOne.Domain.Models;
using System;
using System.Collections.Generic;

namespace AccessOne.Service.Interfaces
{
    public interface IComputadorService : IDisposable
    {
        void Register(Computador computador);
        IEnumerable<Computador> Select();
        Computador Select(Guid id);
        void Update(Computador computador);
        void Remove(Guid id);
    }
}
