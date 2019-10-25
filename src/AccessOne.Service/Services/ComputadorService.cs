using AccessOne.Domain.Core.Bus;
using AccessOne.Domain.Models;
using AccessOne.Domain.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using AccessOne.Domain.Commands;
using AccessOne.Service.Interfaces;

namespace AccessOne.Service.Services
{
    public class ComputadorService : IComputadorService
    {
        private readonly IMapper _mapper;
        private readonly IComputadorRepository _computadorRepository;
        private readonly IMediatorHandler Bus;

        public ComputadorService(IMapper mapper, IComputadorRepository computadorRepository, IMediatorHandler bus)
        {
            _mapper = mapper;
            _computadorRepository = computadorRepository;
            Bus = bus;
        }

        public IEnumerable<Computador> Select()
        {
            return _computadorRepository.Select();
        }

        public Computador Select(Guid id)
        {
            return _computadorRepository.Select(id);
        }

        public void Register(Computador obj)
        {
            var postCommand = _mapper.Map<RegisterNewComputadorCommand>(obj);
            Bus.SendCommand(postCommand);
        }

        public void Update(Computador obj)
        {
            var updateCommand = _mapper.Map<UpdateComputadorCommand>(obj);
            Bus.SendCommand(updateCommand);
        }

        public void Remove(Guid id)
        {
            var removeCommand = new RemoveComputadorCommand(id);
            Bus.SendCommand(removeCommand);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
