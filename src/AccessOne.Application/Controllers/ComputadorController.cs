using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccessOne.Domain.Core.Bus;
using AccessOne.Domain.Core.Notifications;
using AccessOne.Service.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AccessOne.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComputadorController : ApiController
    {
        private readonly IComputadorService _computadorService;

        public ComputadorController(
            IComputadorService computadorService,
            INotificationHandler<DomainNotification> notifications,
            IMediatorHandler mediator) : base(notifications, mediator)
        {
            _computadorService = computadorService;
        }

        // GET: api/Computador
        [HttpGet]
        public IActionResult Get()
        {
            return Response(_computadorService.Select());
        }

        // GET: api/Computador/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Computador
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Computador/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
