using Carter;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Newsletter.Api.Extentions;

namespace Newsletter.Api.Features.Articales.CreateArticale
{
    public  class CreateArticaleEndPoint:ICarterModule 
    {
       
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("api/articales", async ([FromBody] CreateArticaleRequest request, IMediator mediator) =>
            {
                var result = await mediator.Send(request);
                return result.GetResponse();
            });
        }
    }
}
