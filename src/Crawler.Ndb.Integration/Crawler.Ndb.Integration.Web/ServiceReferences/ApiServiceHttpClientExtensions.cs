using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Crawler.Ndb.Integration.Web.ServiceReferences
{
    public static class ApiServiceHttpClientExtensions
    {
        public static IServiceCollection AddApiServiceClient(this IServiceCollection services, string apiBaseAddress)
        {
            services.AddHttpClient("ApiService", client =>
            {
                client.BaseAddress = new Uri(apiBaseAddress);
            });
            return services;
        }
    }
}
