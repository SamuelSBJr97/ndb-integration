using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Crawler.Ndb.Integration.Web.Domain.RestManager.Model;

namespace Crawler.Ndb.Integration.ApiService.Data
{
    public class CrawlerNdbIntegrationApiServiceContext : DbContext
    {
        public CrawlerNdbIntegrationApiServiceContext (DbContextOptions<CrawlerNdbIntegrationApiServiceContext> options)
            : base(options)
        {
        }

        public DbSet<Crawler.Ndb.Integration.Web.Domain.RestManager.Model.RestManager> RestManager { get; set; } = default!;
    }
}
