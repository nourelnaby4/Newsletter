



namespace Newsletter.Api.Shared
{
    public class ResponseHandler
    {
        public Response<T> Deleted<T>()
        {
            return new Response<T>()
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Succeeded = true,
                Message =  "deleted successfully"
            };
        }
        public Response<T> Deleted<T>(T data,string message=null)
        {
            return new Response<T>()
            {
                Data=data,
                StatusCode = System.Net.HttpStatusCode.OK,
                Succeeded = true,
                Message = message?? "deleted successfully"
            };
        }
        public Response<T> Success<T>(T entity, string message = null)
        {
            return new Response<T>()
            {
                Data = entity,
                StatusCode = System.Net.HttpStatusCode.OK,
                Succeeded = true,
                Message = message ?? "success"
            };
        }
        public Response<T> EditSuccess<T>(T entity, string  message = null)
        {
            return new Response<T>()
            {
                Data = entity,
                StatusCode = System.Net.HttpStatusCode.OK,
                Succeeded = true,
                Message = message ?? "updated successfully"
            };
        }
        public Response<T> Success<T>(T entity, string message, object Meta = null)
        {
            return new Response<T>()
            {
                Data = entity,
                StatusCode = System.Net.HttpStatusCode.OK,
                Succeeded = true,
                Message = message,
                Meta = Meta
            };
        }
        public Response<T> Unauthorized<T>(string message=null)
        {
            return new Response<T>()
            {
                StatusCode = System.Net.HttpStatusCode.Unauthorized,
                Succeeded = true,
                Message =message is null? "unautorized" : message,
            };
        }
        public Response<T> Unauthorized<T>(T data, string message = null)
        {
            return new Response<T>()
            {
                Data=data,
                StatusCode = System.Net.HttpStatusCode.Unauthorized,
                Succeeded = true,
                Message = message is null ? "unautorized" : message,
            };
        }
        public Response<T> BadRequest<T>( string message = null)
        {
            return new Response<T>()
            {
                StatusCode = System.Net.HttpStatusCode.BadRequest,
                Succeeded = false,
                Message = message is null ? "bad request" : message,
            };
        }
        public Response<T> BadRequest<T>(T data, string message = null)
        {
            return new Response<T>()
            {
                Data=data,
                StatusCode = System.Net.HttpStatusCode.BadRequest,
                Succeeded = false,
                Message = message is null ? "bad request" : message
            };
        }

        public Response<T> NotFound<T>(string message = null)
        {
            return new Response<T>()
            {
                StatusCode = System.Net.HttpStatusCode.NotFound,
                Succeeded = false,
                Message = message is null ? "not found" : message
            };
        }
        public Response<T> NotFound<T>(T data, string message = null)
        {
            return new Response<T>()
            {
                Data=data,
                StatusCode = System.Net.HttpStatusCode.NotFound,
                Succeeded = false,
                Message = message is null ? "not found" : message
            };
        }


        public Response<T> Created<T>(T entity, object Meta = null)
        {
            return new Response<T>()
            {
                Data = entity,
                StatusCode = System.Net.HttpStatusCode.Created,
                Succeeded = true,
                Message = "created successfully",
                Meta = Meta
            };
        }

        public Response<T> UnprocessableEntity<T>(string message = null)
        {
            return new Response<T>()
            {
                StatusCode = System.Net.HttpStatusCode.UnprocessableEntity,
                Succeeded = false,
                Message = message is null ? "Unprocessable Entity" : message
            };
        }
        public Response<T> UnprocessableEntity<T>(T data, string message = null)
        {
            return new Response<T>()
            {
                Data=data,
                StatusCode = System.Net.HttpStatusCode.UnprocessableEntity,
                Succeeded = false,
                Message = message is null ? "Unprocessable Entity" : message
            };
        }

    }
}
