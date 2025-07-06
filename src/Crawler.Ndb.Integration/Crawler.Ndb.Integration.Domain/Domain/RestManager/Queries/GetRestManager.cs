namespace Crawler.Ndb.Integration.Web.Domain.RestManager.Queries
{
    public class GetRestManager
    {
        public Guid Id { get; private set; }

        public GetRestManager() { }

        public GetRestManager(Guid id)
        {
            Id = id;
        }

        public GetRestManager(string id)
        {
            Id = Guid.Parse(id);
        }
    }
}
