using AccessOne.Domain.Models;
using AccessOne.Domain.Validatons;

namespace AccessOne.Domain.Commands
{
    public class RegisterNewComputadorCommand : ComputadorCommand
    {
        public RegisterNewComputadorCommand(string nome, string ip, int disco, int memoria, Grupo grupo)
        {
            Nome = nome;
            Ip = ip;
            Disco = disco;
            Memoria = memoria;
            Grupo = grupo;
        }

        public override bool IsValid()
        {
            ValidationResult = new RegisterNewComputadorCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
