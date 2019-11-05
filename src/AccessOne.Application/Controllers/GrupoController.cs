using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AccessOne.Domain.Models;
using AccessOne.Service.Interfaces;
using AccessOne.Service.Requests;
using AccessOne.Service.Responses;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AccessOne.Application.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class GrupoController : ControllerBase
    {
        private readonly IGrupoService _grupoService;
        private readonly IMapper _mapper;
        
        public GrupoController(IGrupoService grupoService, IMapper mapper)
        {
            _grupoService = grupoService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var grupos = await _grupoService.SelectAsync();
            var gruposResponse = _mapper.Map<List<Grupo>, List<GrupoResponse>>(grupos);
            return Ok(gruposResponse);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var grupo = await _grupoService.SelectAsync(id);
            var grupoResponse = _mapper.Map<GrupoResponse>(grupo);
            if(grupoResponse != null)return Ok(grupoResponse);

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GrupoCreateRequest grupo)
        {
            var createdGrupo = _mapper.Map<GrupoResponse>(await _grupoService.InsertAsync(_mapper.Map<Grupo>(grupo)));
            var baseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
            var locationUri = baseUrl + "/api/grupo/" + createdGrupo.Id;
            return Created(locationUri, createdGrupo);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] GrupoUpdateRequest grupo)
        {
            var updatedGrupo = _mapper.Map<GrupoResponse>(await _grupoService.UpdateAsync(_mapper.Map<Grupo>(grupo)));
            var baseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
            var locationUri = baseUrl + "/api/grupo/" + updatedGrupo.Id;
            return Ok(updatedGrupo);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            if (await _grupoService.DeleteAsync(id)) return Ok();
            return NotFound();
        }
    }
}