using AccessOne.Domain.Core.Models;
using System;

namespace AccessOne.Domain.Models
{
    public class Comando : Entity
    {
        public string ComandoStr { get; set; }
        public Computador Computador { get; set; }
        public DateTime DataRegistro { get; set; }
        public DateTime? DataExecucao { get; set; }
        public string Retorno { get; set; }
    }
}