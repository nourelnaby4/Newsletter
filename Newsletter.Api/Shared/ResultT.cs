namespace Newsletter.Api.Shared
{
    public class ResultT<T>
    {
       
        public T? Data { get; set; }
        public bool IsSuccess {get;set;}=true;
        public string? message { get; set;}=string.Empty;
    }
}
