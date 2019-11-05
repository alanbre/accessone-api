using System;
using System.ComponentModel.DataAnnotations;
using AccessOne.Domain.Models;

namespace AccessOne.Service.Responses
{
    public class ComputadorResponse
    {  
        [Key]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Ip { get; set; }
        public int Disco { get; set; }
        public int Memoria { get; set; }
        public Grupo Grupo { get; set; }
    }
}