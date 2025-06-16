using FluentValidation;

namespace MediatrVsBrighter.Api.Features.Mediatr.CreateProduct
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Nazwa produktu jest wymagana.")
                .MaximumLength(100).WithMessage("Nazwa produktu nie może przekraczać 100 znaków.");

            RuleFor(x => x.Price)
                .GreaterThan(0).WithMessage("Cena produktu musi być większa od zera.");

            RuleFor(x => x.Description)
                .MaximumLength(500).WithMessage("Opis produktu nie może przekraczać 500 znaków.");
        }
    }
}
