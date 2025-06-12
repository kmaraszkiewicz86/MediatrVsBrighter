using Paramore.Brighter;

namespace MediatrVsBrighter.Api.Features.Brighter.CreateProduct
{
    public class CreateProductCommand : Command, ICommand
    {
        public string Name { get; }
        public decimal Price { get; }
        public string? Description { get; }

        public CreateProductCommand(string name, decimal price, string? description)
            : base(Guid.NewGuid())
        {
            Name = name;
            Price = price;
            Description = description;
        }
    }
}