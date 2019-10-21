using AccessOne.Domain.Models;
using AccessOne.Domain.Validatons;
using System;

namespace AccessOne.Domain.Commands
{
    public class UpdateComputadorCommand : ComputadorCommand
    {
        public UpdateComputadorCommand(Guid id, string nome, string ip, int disco, int memoria, Grupo grupo)
        {
            Id = id;
            Nome = nome;
            Ip = ip;
            Disco = disco;
            Memoria = memoria;
            Grupo = grupo;
        }

        public override bool IsValid()
        {
            ValidationResult = new UpdateComputadorCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
