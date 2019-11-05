using AccessOne.Domain.Models;
using AccessOne.Service.Responses;
using AutoMapper;

namespace AccessOne.Service.AutoMapper
{
    public class DomainToResponseProfile : Profile
    {
        public DomainToResponseProfile()
        {
            CreateMap<Grupo, GrupoResponse>();

            CreateMap<Computador, ComputadorResponse>();
                // .ForMember(cr => cr.Grupo, opt =>
                //     opt.MapFrom(src => new GrupoResponse{Id = src.Grupo.Id, Nome = src.Grupo.Nome}));
        }
    }
}