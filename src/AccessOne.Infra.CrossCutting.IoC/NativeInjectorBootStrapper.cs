using AccessOne.Domain.Interfaces;
using AccessOne.Infra.Data.Context;
using AccessOne.Infra.Data.Repository;
using AccessOne.Service.Interfaces;
using AccessOne.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AccessOne.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Service
            services.AddScoped<IComputadorService, ComputadorService>();
            services.AddScoped<IGrupoService, GrupoService>();

            // Infra Data
            services.AddScoped<IComputadorRepository, ComputadorRepository>();
            services.AddScoped<IGrupoRepository, GrupoRepository>();

            services.AddScoped<AccessOneContext>();
        }
    }
}
