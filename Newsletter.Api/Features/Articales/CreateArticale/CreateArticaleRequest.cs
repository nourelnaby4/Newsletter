using MediatR;
using Newsletter.Api.Shared;

namespace Newsletter.Api.Features.Articales.CreateArticale
{
    public class CreateArticaleRequest : IRequest<Response< string>>
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public List<string> Tags { get; set; } = new();
        
    }
}
