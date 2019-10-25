using AccessOne.Domain.CommandHandlers;
using AccessOne.Domain.Commands;
using AccessOne.Domain.Core.Bus;
using AccessOne.Domain.Core.Notifications;
using AccessOne.Domain.Events;
using AccessOne.Domain.Interfaces;
using AccessOne.Infra.CrossCutting.Bus;
using AccessOne.Infra.Data.Context;
using AccessOne.Infra.Data.Repository;
using AccessOne.Infra.Data.UoW;
using AccessOne.Service.Interfaces;
using AccessOne.Service.Services;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace AccessOne.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Domain Bus (Mediator)
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            // Service
            services.AddScoped<IComputadorService, ComputadorService>();

            // Domain Events
            services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();

            // Domain Commands
            services.AddScoped<IRequestHandler<RegisterNewComputadorCommand, bool>, ComputadorCommandHandler>();
            services.AddScoped<IRequestHandler<UpdateComputadorCommand, bool>, ComputadorCommandHandler>();
            services.AddScoped<IRequestHandler<RemoveComputadorCommand, bool>, ComputadorCommandHandler>();

            // Infra Data
            services.AddScoped<IComputadorRepository, ComputadorRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<AccessOneContext>();


        }
    }
}
