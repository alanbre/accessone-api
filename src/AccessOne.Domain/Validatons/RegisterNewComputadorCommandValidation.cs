using AccessOne.Domain.Commands;

namespace AccessOne.Domain.Validatons
{
    public class RegisterNewComputadorCommandValidation : ComputadorValidation<RegisterNewComputadorCommand>
    {
        public RegisterNewComputadorCommandValidation()
        {
            ValidateNome();
            ValidateIp();
            ValidateDisco();
            ValidateMemoria();
            ValidateGrupo();
        }
    }
}
