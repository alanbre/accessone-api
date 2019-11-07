using System;
using System.ComponentModel.DataAnnotations.Schema;
using AccessOne.Domain.Models;

namespace AccessOne.Service.Requests
{
    public class ComputadorUpdateRequest
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Ip { get; set; }
        public int Disco { get; set; }
        public int Memoria { get; set; }
        [ForeignKey("GrupoId")]
        public Grupo Grupo { get; set; }
        public Guid? GrupoId { get; set; }
    }
}