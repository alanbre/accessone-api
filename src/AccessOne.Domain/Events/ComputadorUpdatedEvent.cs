using AccessOne.Domain.Core.Events;
using AccessOne.Domain.Models;
using System;

namespace AccessOne.Domain.Events
{
    public class ComputadorUpdatedEvent : Event
    {
        public ComputadorUpdatedEvent(Guid id, string nome, string ip, int disco, int memoria, Grupo grupo)
        {
            Id = id;
            Nome = nome;
            Ip = ip;
            Disco = disco;
            Memoria = memoria;
            Grupo = grupo;
        }

        public Guid Id { get; set; }
        public string Nome { get; private set; }
        public string Ip { get; private set; }
        public int Disco { get; private set; }
        public int Memoria { get; private set; }
        public Grupo Grupo { get; private set; }
    }
}
