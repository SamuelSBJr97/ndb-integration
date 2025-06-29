namespace Crawler.Ndb.Integration.ApiService.Domain
{
    public class Database
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ConnectionString { get; set; }
        public string Provider { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }

        public Database()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
            IsActive = true;
        }
    }
}
