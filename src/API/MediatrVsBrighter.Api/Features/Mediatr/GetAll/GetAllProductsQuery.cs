using MediatR;
using MediatrVsBrighter.Api.Features.Mediatr.GetAll;

namespace MediatrVsBrighter.Api.Features.Mediatr.GetAll
{
    public record GetAllProductsQuery : IRequest<List<ProductDto>>;
}