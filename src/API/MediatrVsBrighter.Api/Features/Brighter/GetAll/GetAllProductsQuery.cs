using Paramore.Brighter;

namespace MediatrVsBrighter.Api.Features.Brighter.GetAll
{
    public class GetAllProductsQuery : Request
    {
        public GetAllProductsQuery() : base(new ReplyAddress(string.Empty, Guid.NewGuid())) { }
    }
}