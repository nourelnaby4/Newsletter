namespace Newsletter.Api.Entities
{
    public class Articale
    {
        public Guid Id { get; set; }= Guid.NewGuid();
        public string Title { get; set; }
        public string Content {  get; set; }=string.Empty;
        public List<string> Tags { get; set; } = new();
        public DateTime CreatedOnUtc { get; set; }=DateTime.UtcNow;
        public DateTime PublishedOnUtc {  get; set; }=DateTime.UtcNow;

    }
}
