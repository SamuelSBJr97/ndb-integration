using Crawler.Ndb.Integration.Web.Domain.RestManager.Model;
using Microsoft.Extensions.DependencyInjection;

namespace Crawler.Ndb.Integration.Web.Services
{
    public class RestManagersApiClient
    {
        private readonly HttpClient _httpClient;
        
        public RestManagersApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<RestManager>> GetAllAsync()
            => await _httpClient.GetFromJsonAsync<List<RestManager>>("api/RestManagers");

        public async Task<RestManager> GetByIdAsync(Guid id)
            => await _httpClient.GetFromJsonAsync<RestManager>($"api/RestManagers/{id}");

        public async Task<RestManager> CreateAsync(RestManager restManager)
        {
            var response = await _httpClient.PostAsJsonAsync("api/RestManagers", restManager);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<RestManager>();
        }

        public async Task UpdateAsync(RestManager restManager)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/RestManagers/{restManager.Id}", restManager);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteAsync(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/RestManagers/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}