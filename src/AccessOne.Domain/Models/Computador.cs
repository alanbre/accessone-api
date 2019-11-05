using AccessOne.Domain.Core.Models;
using System;
using System.Collections.Generic;

namespace AccessOne.Domain.Models
{
    public class Computador : Entity
    {
        public Computador(Guid id, string nome, string ip, int disco, int memoria, Grupo grupo)
        {
            Id = id;
            Nome = nome;
            Ip = ip;
            Disco = disco;
            Memoria = memoria;
            Grupo = grupo;
        }

        protected Computador() { }

        public string Nome { get; protected set; }
        public string Ip { get; protected set; }
        public int Disco { get; protected set; }
        public int Memoria { get; protected set; }
        public Grupo Grupo { get; protected set; }
        public ICollection<Comando> Comandos { get; protected set; }
    }
}