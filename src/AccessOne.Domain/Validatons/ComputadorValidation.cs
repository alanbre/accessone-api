using AccessOne.Domain.Commands;
using FluentValidation;
using System;

namespace AccessOne.Domain.Validatons
{
    public abstract class ComputadorValidation<T> : AbstractValidator<T> where T : ComputadorCommand
    {
        protected void ValidateId()
        {
            RuleFor(c => c.Id)
                .NotEqual(Guid.Empty);
        }

        protected void ValidateNome()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor, preencha o nome")
                .Length(2, 100).WithMessage("Nome deve conter de 2 a 100 caracteres");
        }

        protected void ValidateIp()
        {
            RuleFor(c => c.Ip)
                .NotEmpty().WithMessage("Por favor, preencha o IP")
                .MinimumLength(8).WithMessage("O IP deve possuir no mínimo 8 dígitos")
                .Matches("^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$").WithMessage("IP inválido");
        }

        protected void ValidateDisco()
        {
            RuleFor(c => c.Disco)
                .NotEmpty().WithMessage("Por favor preencha o espaço em disco")
                .GreaterThan(0).WithMessage("O espaço em disco deve ser maior que zero");
        }

        protected void ValidateMemoria()
        {
            RuleFor(c => c.Memoria)
                .NotEmpty().WithMessage("Por favor preencha a memória ram")
                .GreaterThan(0).WithMessage("A memória ram deve ser maior que zero");
        }

        protected void ValidateGrupo()
        {
            RuleFor(c => c.Grupo)
                .NotNull().WithMessage("O grupo deve ser informado.")
                .NotEmpty().WithMessage("O grupo deve ser informado.");
        }
    }
}
