using AccessOne.Domain.Commands;

namespace AccessOne.Domain.Validatons
{
    public class UpdateComputadorCommandValidation : ComputadorValidation<UpdateComputadorCommand>
    {
        public UpdateComputadorCommandValidation()
        {
            ValidateId();
            ValidateNome();
            ValidateIp();
            ValidateDisco();
            ValidateMemoria();
            ValidateGrupo();
        }
    }
}
