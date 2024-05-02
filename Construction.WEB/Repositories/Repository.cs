
using System.Text.Json;

namespace Construction.WEB.Repositories
{
    public class Repository : IRepository
    {
        private readonly HttpClient httpClient;

        private JsonSerializerOptions _jsonSerializerOptions => new JsonSerializerOptions
        {

            PropertyNameCaseInsensitive = true

        };
        Task<HttpResponseWrapper<T>> IRepository.GetAsync<T>(string url)
        {
            throw new NotImplementedException();
        }

        Task<HttpResponseWrapper<object>> IRepository.Post<T>(string url, T model)
        {
            throw new NotImplementedException();
        }

        Task<HttpResponseWrapper<TResponse>> IRepository.Post<T, TResponse>(string url, T model)
        {
            throw new NotImplementedException();
        }
    }
}
