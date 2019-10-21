using AccessOne.Domain.Core.Bus;
using AccessOne.Domain.Models;
using AccessOne.Domain.Interfaces;
using AutoMapper;
using FluentValidation;
using System;
using System.Collections.Generic;

namespace AccessOne.Service.Services
{
    public class ComputadorService<T> : IService<T> where T : Entity
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

        public Computador Post(Computador obj)
        {
            var postCommand = _mapper.Map<Re>
        }

        public T Put<V>(T obj) where V : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<V>());

            repository.Update(obj);
            return obj;
        }

        public void Delete(int id)
        {
            if (id == 0)
                throw new ArgumentException("O id não pode ser zero.");

            repository.Delete(id);
        }

        public IList<T> Get() => repository.Select();

        public T Get(int id)
        {
            if (id == 0)
                throw new ArgumentException("O id não pode ser zero.");

            return repository.Select(id);
        }

        private void Validate(T obj, AbstractValidator<T> validator)
        {
            if (obj == null)
                throw new Exception("Registros não detectados!");

            validator.ValidateAndThrow(obj);
        }
    }
}
