using MediatR;
using MediatrVsBrighter.Api.Database.Entities;

namespace MediatrVsBrighter.Api.Features.Mediatr.CreateProduct
{
    public record CreateProductCommand(string Name, decimal Price, string? Description) : IRequest<ProductDto>;

    public class CreateProductCommandHandler(ICreateProductRepository repository,
        CreateProductCommandValidator validatior) : IRequestHandler<CreateProductCommand, ProductDto>
    {
        public async Task<ProductDto> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var result = await validatior.ValidateAsync(request, cancellationToken);

            var product = new Product
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Price = request.Price,
                Description = request.Description
            };

            await repository.AddAsync(product);

            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Description = product.Description
            };
        }
    }
}
