using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PagueVeloz.NET.Util
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
            var http = new HttpClient();

            http.BaseAddress = new Uri(_client.BaseURL);
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

        public async Task<HttpResponseMessage> GetAsync(string url)
        {
            using (var http = GetHttpClient())
            {
                return await http.GetAsync(url);
            }
        }

        public async Task<HttpResponseMessage> PostAsync<T>(string url, T content)
        {
            var body = Stringfy(content);

            using (var http = GetHttpClient())
            {
                return await http.PostAsync(url, body);
            }
        }

        public async Task<HttpResponseMessage> PutAsync<T>(string url, T content)
        {
            var body = Stringfy(content);

            using (var http = GetHttpClient())
            {
                return await http.PutAsync(url, body);
            }
        }

        public async Task<HttpResponseMessage> DeleteAsync(string url)
        {
            using (var http = GetHttpClient())
            {
                return await http.DeleteAsync(url);
            }
        }

        public async Task<T> NormalizeResponse<T>(HttpResponseMessage response)
        {
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Erro na requisição"); //TODO: Tratar erros
            }

            return JsonConvert.DeserializeObject<T>(content);
        }
    }
}
