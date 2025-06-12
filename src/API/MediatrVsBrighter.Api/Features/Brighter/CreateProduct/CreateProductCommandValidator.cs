using FluentValidation;

namespace MediatrVsBrighter.Api.Features.Brighter.CreateProduct
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Nazwa produktu jest wymagana.")
                .MaximumLength(100).WithMessage("Nazwa produktu nie mo�e przekracza� 100 znak�w.");

            RuleFor(x => x.Price)
                .GreaterThan(0).WithMessage("Cena produktu musi by� wi�ksza od zera.");

            RuleFor(x => x.Description)
                .MaximumLength(500).WithMessage("Opis produktu nie mo�e przekracza� 500 znak�w.");
        }
    }
}