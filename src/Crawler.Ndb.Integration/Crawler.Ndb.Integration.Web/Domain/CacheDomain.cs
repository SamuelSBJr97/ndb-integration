namespace Crawler.Ndb.Integration.Web.Domain
{
    public class CacheField
    {
        public string Name { get; }
        public string Type { get; }

        public CacheField(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }

    public class CacheInstance
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public List<CacheField> Fields { get; private set; }

        public CacheInstance(string name, List<CacheField> fields)
        {
            Id = Guid.NewGuid();
            Name = name;
            Fields = fields;
        }
    }

    public interface ICacheRepository
    {
        Task CreateCacheAsync(CacheInstance instance);
        Task<IEnumerable<CacheInstance>> GetAllCachesAsync();
        // Métodos adicionais para manipulação do cache podem ser adicionados aqui
    }
}
