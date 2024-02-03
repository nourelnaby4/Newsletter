using MediatR;
using Newsletter.Api.Shared;

namespace Newsletter.Api.Features.Articales.EditArticale
{
    public class EditArticaleRequest : IRequest<Response< string>>
    {
        public Guid ArticaleId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public List<string> Tags { get; set; } = new();
        
    }
}
