using System;
using AccessOne.Service.AutoMapper;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace AccessOne.Application.Configurations
{
    public static class AutoMapperSetup
  {
      public static void AddAutoMapperSetup(this IServiceCollection services)
      {
          if (services == null) throw new ArgumentNullException(nameof(services));

          services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

          // Registering Mappings automatically only works if the 
          // Automapper Profile classes are in ASP.NET project
          AutoMapperConfig.RegisterMappings();
      }
  }
}