using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AccessOne.Domain.Interfaces;
using AccessOne.Domain.Models;
using AccessOne.Service.Interfaces;

namespace AccessOne.Service.Services
{
    public class GrupoService : IGrupoService
    {

        private readonly IGrupoRepository _grupoRepository;

        public GrupoService(IGrupoRepository grupoRepository)
        {
            _grupoRepository = grupoRepository;
        }

        public async Task<List<Grupo>> SelectAsync()
        {
            return await _grupoRepository.SelectAsync();;
        }

        public async Task<Grupo> SelectAsync(Guid id)
        {
            return await _grupoRepository.SelectAsync(id);
        }

        public async Task<Grupo> InsertAsync(Grupo grupo)
        {
            return await _grupoRepository.InsertAsync(grupo);
        }

        public async Task<Grupo> UpdateAsync(Grupo grupo)
        {
            return await _grupoRepository.UpdateAsync(grupo);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            return await _grupoRepository.DeleteAsync(id);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}