using FluentValidation;

namespace AirLiquide.Domain.Entities.Validations
{
    public class ClienteValidation : AbstractValidator<Cliente>
    {
        public ClienteValidation()
        {
            RuleFor(x => x.Nome).NotEmpty().WithMessage("O Nome é obrigatório");
            RuleFor(x => x.Nome).MinimumLength(5).WithMessage("Digite pelo menos 5 letras");
        }
    }
}
