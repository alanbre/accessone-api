using AutoMapper;

namespace AccessOne.Service.AutoMapper
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DomainToResponseProfile());
                cfg.AddProfile(new RequestToDomainProfile());
            });

            config.AssertConfigurationIsValid();

            return config;
        }
    }
}