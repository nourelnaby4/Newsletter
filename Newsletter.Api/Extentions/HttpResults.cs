using Microsoft.AspNetCore.Mvc;
using Newsletter.Api.Shared;
using System.Net;

namespace Newsletter.Api.Extentions
{
    public static class HttpResults
    {
           public static ObjectResult GetResponse<T>(this Response<T> response) =>
           response.StatusCode switch
           {
               HttpStatusCode.OK => new OkObjectResult(response),
               HttpStatusCode.Created => new CreatedResult(string.Empty, response),
               HttpStatusCode.Unauthorized => new UnauthorizedObjectResult(response),
               HttpStatusCode.BadRequest => new BadRequestObjectResult(response),
               HttpStatusCode.NotFound => new NotFoundObjectResult(response),
               HttpStatusCode.Accepted => new AcceptedResult(string.Empty, response),
               HttpStatusCode.UnprocessableEntity => new UnprocessableEntityObjectResult(response),
               _ => new BadRequestObjectResult(response)
           };
    }
}
