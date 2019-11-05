using System;
using AccessOne.Domain.Core.Models;

namespace AccessOne.Domain.Models
{
    public class Grupo : Entity
    {
        public Grupo(Guid id, string nome)
        {
            Nome = nome;
            Id = id;
        }

        protected Grupo() {}

        public string Nome { get; protected set; }
    }
}

