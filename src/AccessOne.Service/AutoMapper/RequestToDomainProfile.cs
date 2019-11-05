using System;
using AccessOne.Domain.Models;
using AccessOne.Service.Requests;
using AutoMapper;

namespace AccessOne.Service.AutoMapper
{
    public class RequestToDomainProfile : Profile
    {
        public RequestToDomainProfile()
        {
            CreateMap<GrupoCreateRequest, Grupo>()
                .ConstructUsing(g => new Grupo(Guid.NewGuid(), g.Nome))
                .ForMember(x => x.Id, opt => opt.Ignore());
            CreateMap<GrupoUpdateRequest, Grupo>();
        }
    }
}