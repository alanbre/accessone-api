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

            CreateMap<ComputadorCreateRequest, Computador>()
                .ConstructUsing(c => new Computador(Guid.NewGuid(), c.Nome, c.Ip, c.Disco, c.Memoria, c.Grupo))
                .ForMember(x => x.Id, opt => opt.Ignore())
                .ForMember(x => x.Comandos, opt => opt.Ignore())
                .ForMember(x => x.GrupoId, opt => opt.Ignore());

            CreateMap<ComputadorUpdateRequest, Computador>()
                .ForMember(x => x.Comandos, opt => opt.Ignore());

            CreateMap<ComandoCreateRequest, Comando>()
                .ConstructUsing(c => new Comando(Guid.NewGuid(), c.ComandoStr, c.Computador))
                .ForMember(x => x.Id, opt => opt.Ignore())
                .ForMember(x => x.DataExecucao, opt => opt.Ignore())
                .ForMember(x => x.DataRegistro, opt => opt.Ignore())
                .ForMember(x => x.Retorno, opt => opt.Ignore());
        }
    }
}