using Mediatr.Features.Mediatr.GetAll;
using MediatR;

namespace MediatrVsBrighter.Api.Features.Mediatr.GetAll
{
    public record GetAllProductsQuery : IRequest<List<ProductDto>>;
}