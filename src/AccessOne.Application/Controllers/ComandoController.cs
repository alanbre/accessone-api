using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AccessOne.Service.Interfaces;
using AccessOne.Service.Responses;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AccessOne.Application.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class ComandoController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IComandoService _comandoService;

        public ComandoController(IComandoService comandoService, IMapper mapper)
        {
            _mapper = mapper;
            _comandoService = comandoService;
        }
    }
}