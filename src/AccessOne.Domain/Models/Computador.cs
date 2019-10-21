using System;
using System.Collections.Generic;

namespace AccessOne.Domain.Models
{
    public class Computador : Entity
    {
        public Computador(Guid id, string nome, string ip, int espaco, int memoria, Grupo grupo)
        {
            Id = id;
            Nome = nome;
            Ip = ip;
            Disco = espaco;
            Memoria = memoria;
            Grupo = grupo;
        }

        protected Computador() { }

        public string Nome { get; private set; }
        public string Ip { get; private set; }
        public int Disco { get; private set; }
        public int Memoria { get; private set; }
        public Grupo Grupo { get; private set; }
        public ICollection<Comando> Comandos { get; private set; }
    }
}