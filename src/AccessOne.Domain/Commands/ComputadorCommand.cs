using AccessOne.Domain.Core.Commands;
using AccessOne.Domain.Models;
using System;

namespace AccessOne.Domain.Commands
{
    public abstract class ComputadorCommand : Command
    {
        public Guid Id { get; protected set; }
        public string Nome { get; protected set; }
        public string Ip { get; protected set; }
        public int Disco { get; protected set; }
        public int Memoria { get; protected set; }
        public Grupo Grupo { get; protected set; }
    }
}
