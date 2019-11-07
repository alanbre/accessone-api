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
        private readonly IGrupoService _grupoService;
        private readonly IMapper _mapper;

        public ComputadorController(IComputadorService computadorService, IGrupoService grupoService, IMapper mapper)
        {
            _computadorService = computadorService;
            _grupoService = grupoService;
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
            if (computadorResponse != null) return Ok(computadorResponse);
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ComputadorCreateRequest computadorRequest)
        {
            var grupo = computadorRequest.Grupo;
            if (computadorRequest.GrupoId != Guid.Empty)
            {
                grupo = await _grupoService.SelectAsync(computadorRequest.GrupoId);
                if (grupo == null) return NotFound("Grupo não encontrado");
                computadorRequest.Grupo = grupo;
            }
            var computador = _mapper.Map<Computador>(computadorRequest);
            var createdComputador = await _computadorService.InsertAsync(computador);
            var computadorResponse = _mapper.Map<ComputadorResponse>(createdComputador);
            var baseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
            var locationUri = $"{baseUrl}/api/computador/{computadorResponse.Id}";
            return Created(locationUri, computadorResponse);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] ComputadorUpdateRequest computadorRequest)
        {
            if(!await _computadorService.Exists(computadorRequest.Id)) return NotFound();

            if (computadorRequest.GrupoId != Guid.Empty && computadorRequest.GrupoId != null)
            {
                computadorRequest.Grupo = await _grupoService.SelectAsync((Guid)computadorRequest.GrupoId);
                if (computadorRequest.Grupo == null) return NotFound("Grupo não encontrado");
            }
            var computador = _mapper.Map<Computador>(computadorRequest);
            var updatedComputador = await _computadorService.UpdateAsync(computador);
            var computadorResponse = _mapper.Map<ComputadorResponse>(updatedComputador);

            return Ok(computadorResponse);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            if(!await _computadorService.Exists(id)) return NotFound();
            var deleted = await _computadorService.DeleteAsync(id);
            if(deleted) return Ok();

            return BadRequest();
        }
    }
}
