using MediatrVsBrighter.Api.Database.Entities;
using Paramore.Brighter;

namespace MediatrVsBrighter.Api.Features.Brighter.CreateProduct
{
    public class CreateProductCommandHandler(
        ICreateProductRepository repository,
        CreateProductCommandValidator validator) : RequestHandlerAsync<CreateProductCommand>
    {
        public override async Task<CreateProductCommand> HandleAsync(CreateProductCommand command, CancellationToken cancellationToken = default)
        {
            var result = await validator.ValidateAsync(command, cancellationToken);

            var product = new Product
            {
                Id = Guid.NewGuid(),
                Name = command.Name,
                Price = command.Price,
                Description = command.Description
            };

            await repository.AddAsync(product);

            return command;
        }
    }
}