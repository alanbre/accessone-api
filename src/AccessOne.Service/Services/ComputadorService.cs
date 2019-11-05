using AccessOne.Domain.Models;
using AccessOne.Domain.Interfaces;
using System;
using System.Collections.Generic;
using AccessOne.Service.Interfaces;
using System.Threading.Tasks;

namespace AccessOne.Service.Services
{
    public class ComputadorService : IComputadorService
    {
        private readonly IComputadorRepository _computadorRepository;

        public ComputadorService(IComputadorRepository computadorRepository)
        {
            _computadorRepository = computadorRepository;
        }

        public async Task<List<Computador>> SelectAsync()
        {
            return await _computadorRepository.SelectAsync();
        }

        public async Task<Computador> SelectAsync(Guid id)
        {
            return await _computadorRepository.SelectAsync(id);
        }

        public async Task<Computador> InsertAsync(Computador computador)
        {
            return await _computadorRepository.InsertAsync(computador);
        }

        public async Task<Computador> UpdateAsync(Computador computador)
        {
            return await _computadorRepository.UpdateAsync(computador);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            return await _computadorRepository.DeleteAsync(id);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
