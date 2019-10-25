using System;
using System.Threading;
using System.Threading.Tasks;
using AccessOne.Domain.Commands;
using AccessOne.Domain.Core.Bus;
using AccessOne.Domain.Core.Notifications;
using AccessOne.Domain.Events;
using AccessOne.Domain.Interfaces;
using AccessOne.Domain.Models;
using MediatR;

namespace AccessOne.Domain.CommandHandlers
{
    public class ComputadorCommandHandler : CommandHandler,
        IRequestHandler<RegisterNewComputadorCommand, bool>,
        IRequestHandler<UpdateComputadorCommand, bool>,
        IRequestHandler<RemoveComputadorCommand, bool>
    {
        private readonly IComputadorRepository _computadorRepository;
        private readonly IMediatorHandler Bus;

        public ComputadorCommandHandler(IComputadorRepository computadorRepository,
                                        IUnitOfWork uow,
                                        IMediatorHandler bus,
                                        INotificationHandler<DomainNotification> notifications) : base(uow, bus, notifications)
        {
            _computadorRepository = computadorRepository;
            Bus = bus;
        }

        public Task<bool> Handle(RegisterNewComputadorCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid())
            {
                NotifyValidationErrors(message);
                return Task.FromResult(false);
            }

            var computador = new Computador(Guid.NewGuid(),
                                            message.Nome,
                                            message.Ip,
                                            message.Disco,
                                            message.Memoria,
                                            message.Grupo);

            _computadorRepository.Insert(computador);

            if(Commit())
            {
                Bus.RaiseEvent(new ComputadorRegisteredEvent(computador.Id,
                                                             computador.Nome,
                                                             computador.Ip,
                                                             computador.Disco,
                                                             computador.Memoria,
                                                             computador.Grupo));
            }

            return Task.FromResult(true);
        }


        public Task<bool> Handle(UpdateComputadorCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid())
            {
                NotifyValidationErrors(message);
                return Task.FromResult(false);
            }

            var computador = new Computador(Guid.NewGuid(),
                                            message.Nome,
                                            message.Ip,
                                            message.Disco,
                                            message.Memoria,
                                            message.Grupo);

            _computadorRepository.Update(computador);

            if (Commit())
            {
                Bus.RaiseEvent(new ComputadorUpdatedEvent(computador.Id,
                                                          computador.Nome,
                                                          computador.Ip,
                                                          computador.Disco,
                                                          computador.Memoria,
                                                          computador.Grupo));
            }

            return Task.FromResult(true);
        }

        public Task<bool> Handle(RemoveComputadorCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid())
            {
                NotifyValidationErrors(message);
                return Task.FromResult(false);
            }

            _computadorRepository.Delete(message.Id);

            if (Commit())
            {
                Bus.RaiseEvent(new ComputadorRemovedEvent(message.Id));
            }

            return Task.FromResult(true);
        }

        public void Dispose()
        {
            _computadorRepository.Dispose();
        }

    }
}
