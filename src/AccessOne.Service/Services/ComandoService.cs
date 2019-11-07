using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AccessOne.Domain.Interfaces;
using AccessOne.Domain.Models;
using AccessOne.Service.Interfaces;

namespace AccessOne.Service.Services
{
    public class ComandoService : IComandoService
    {
        private readonly IComandoRepository _comandoRepository;

        public ComandoService(IComandoRepository comandoRepository)
        {
            _comandoRepository = comandoRepository;
        }

        public async Task<Comando> InsertAsync(Comando comando)
        {
            return await _comandoRepository.InsertAsync(comando);
        }

        public async Task<List<Comando>> SelectByComputador(Guid computadorId)
        {
            return await _comandoRepository.SelectByComputadorAsync(computadorId);
        }

        public async Task<Comando> UpdateAsync(Comando comando)
        {
            return await _comandoRepository.UpdateAsync(comando);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}