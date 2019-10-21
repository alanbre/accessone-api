using AccessOne.Domain.Commands;

namespace AccessOne.Domain.Validatons
{
    public class RemoveComputadorCommandValidation : ComputadorValidation<RemoveComputadorCommand>
    {
        public RemoveComputadorCommandValidation()
        {
            ValidateIp();
        }
    }
}
