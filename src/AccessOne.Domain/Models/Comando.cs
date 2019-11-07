using AccessOne.Domain.Core.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccessOne.Domain.Models
{
    public class Comando : Entity
    {
        public Comando(Guid id, string comandoStr, Computador computador)
        {
            Id = id;
            ComandoStr = comandoStr;
            Computador = computador;    
        }

        protected Comando() {}

        public string ComandoStr { get; protected set; }
        [ForeignKey("ComputadorId")]
        public Computador Computador { get; protected set; }
        public Guid ComputadorId { get; protected set; }
        public DateTime DataRegistro { get; protected set; }
        public DateTime? DataExecucao { get; protected set; }
        public string Retorno { get; protected set; }
    }
}