using System;
using System.ComponentModel.DataAnnotations.Schema;
using AccessOne.Domain.Models;

namespace AccessOne.Service.Requests
{
    public class ComputadorCreateRequest
    {
        public string Nome { get; set; }
        public string Ip { get; set; }
        public int Disco { get; set; }
        public int Memoria { get; set; }
        public Guid GrupoId { get; set; }
        [ForeignKey("GrupoId")]
        public Grupo Grupo { get; set; }
    }
}