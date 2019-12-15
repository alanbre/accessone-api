using System;
using System.ComponentModel.DataAnnotations;
using AccessOne.Domain.Models;

namespace AccessOne.Service.Responses
{
    public class ComandoResponse
    {
        [Key]
        public Guid Id { get; set; }
        public string ComandoStr { get; set; }
        public Computador Computador { get; set; }
        public DateTime DataRegistro { get; set; }
        public DateTime? DataExecucao { get; set; }
        public string Retorno { get; set; }
    }
}