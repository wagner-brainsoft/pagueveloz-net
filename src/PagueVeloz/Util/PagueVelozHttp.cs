using Newtonsoft.Json;
using System;
using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PagueVeloz.Util
{
    internal class PagueVelozHttp
    {
        private readonly PagueVelozClient _client;

        public PagueVelozHttp(PagueVelozClient client)
        {
            _client = client;
        }

        private HttpClient GetHttpClient()
        {
            var http = new HttpClient {BaseAddress = new Uri(_client.BaseURL)};

            http.DefaultRequestHeaders.Add("Accept", "application/json");
            http.DefaultRequestHeaders.Add("Authorization", _client.Credentials.Authorization);

            return http;
        }

        private string Serialize<T>(T value)
        {
            return JsonConvert.SerializeObject(value);
        }

        private StringContent Stringfy<T>(T value)
        {
            return new StringContent(Serialize(value), Encoding.UTF8, "application/json");
        }

        private async Task EnsureSuccessStatusCode(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var message = $"A API retornou status code {(int) response.StatusCode} para o request.";

                if (string.IsNullOrWhiteSpace(content))
                {
                    new HttpRequestException(message);
                }

                throw new HttpRequestException(message, new HttpRequestException(content));
            }
        }

        public async Task<HttpResponseMessage> GetAsync(string url, CancellationToken cancellationToken = default)
        {
            using var http = GetHttpClient();
            return await http.GetAsync(url, cancellationToken);
        }

        public async Task<HttpResponseMessage> PostAsync<T>(string url, T content, CancellationToken cancellationToken = default)
        {
            var body = Stringfy(content);

            using var http = GetHttpClient();
            return await http.PostAsync(url, body, cancellationToken);
        }

        public async Task<HttpResponseMessage> PutAsync<T>(string url, T content, CancellationToken cancellationToken = default)
        {
            var body = Stringfy(content);

            using var http = GetHttpClient();
            return await http.PutAsync(url, body, cancellationToken);
        }

        public async Task<HttpResponseMessage> DeleteAsync(string url, CancellationToken cancellationToken = default)
        {
            using var http = GetHttpClient();
            return await http.DeleteAsync(url, cancellationToken);
        }

        public async Task<T> NormalizeResponse<T>(HttpResponseMessage response)
        {
            await EnsureSuccessStatusCode(response);

            var content = await response.Content.ReadAsStringAsync();

            var settings = new JsonSerializerSettings()
            {
                Culture = new CultureInfo("pt-BR")
            };

            return JsonConvert.DeserializeObject<T>(content, settings);
        }
    }
}