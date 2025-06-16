namespace MediatrVsBrighter.Api.Features.Mediatr.CreateProduct
{
    public record ProductDto
    {
        public Guid Id { get; init; }
        public string Name { get; init; } = string.Empty;
        public decimal Price { get; init; }
        public string? Description { get; init; }
    }
}
