using Carter;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Newsletter.Api.Extentions;

namespace Newsletter.Api.Features.Articales.EditArticale
{
    public  class EditArticaleEndPoint:ICarterModule 
    {
       
        public void AddRoutes(IEndpointRouteBuilder app)
        {
          
            app.MapPut("api/articales", async ([FromBody] EditArticaleRequest request, IMediator mediator) =>
            {
                var result = await mediator.Send(request);
                return  result.GetResponse();
            });
        }
    }
}
