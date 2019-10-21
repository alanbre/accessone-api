using AccessOne.Domain.Validatons;
using System;

namespace AccessOne.Domain.Commands
{
    public class RemoveComputadorCommand : ComputadorCommand
    {
        public RemoveComputadorCommand(Guid id)
        {
            Id = id;
            AggregateId = id;
        }

        public override bool IsValid()
        {
            ValidationResult = new RemoveComputadorCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
