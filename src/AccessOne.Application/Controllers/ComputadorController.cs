using AccessOne.Domain.Models;
using AccessOne.Service.Interfaces;
using AccessOne.Service.Requests;
using AccessOne.Service.Responses;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccessOne.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComputadorController : ControllerBase
    {
        private readonly IComputadorService _computadorService;
        private readonly IMapper _mapper;

        public ComputadorController(IComputadorService computadorService, IMapper mapper)
        {
            _computadorService = computadorService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var computadores = await _computadorService.SelectAsync();
            var computadoresResponse = _mapper.Map<List<Computador>, List<ComputadorResponse>>(computadores);
            return Ok(computadoresResponse);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var computador = await _computadorService.SelectAsync(id);
            var computadorResponse = _mapper.Map<ComputadorResponse>(computador);
            if(computadorResponse != null) return Ok(computadorResponse);
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ComputadorCreateRequest computador)
        {
            return Ok();
        }
    }
}
