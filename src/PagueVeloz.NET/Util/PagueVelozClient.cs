using PagueVeloz.NET.APIs.Boleto;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace PagueVeloz.NET.Util
{
    /// <summary>
    /// Client para realizar requisições nas API's PagueVeloz.
    /// </summary>
    public class PagueVelozClient
    {
        private const string sandboxBaseUrl = "https://sandbox.pagueveloz.com.br/";
        private const string producaoBaseUrl = "https://www.pagueveloz.com.br/";

        private PagueVelozHttp _http;

        /// <summary>
        /// Ambiente PagueVeloz onde o Cliente fará as requisições.
        /// </summary>
        public PagueVelozEnvironment Environment { get; private set; }

        /// <summary>
        /// Credenciais geradas para o Client.
        /// </summary>
        public PagueVelozCredentials Credentials { get; private set; }

        /// <summary>
        /// URL do host PagueVeloz (baseado no 'environment' selecionado).
        /// </summary>
        public string BaseURL { get; private set; }

        public PagueVelozClient(PagueVelozEnvironment environment, PagueVelozCredentials credentials)
        {
            Environment = environment;
            Credentials = credentials;
            BaseURL = ResolveBaseURL(Environment);

            _http = new PagueVelozHttp(this);

            Boletos = new BoletoAPI(this);
        }

        private string ResolveBaseURL(PagueVelozEnvironment environment)
        {
            if (environment == PagueVelozEnvironment.Sandbox)
            {
                return sandboxBaseUrl;
            }
            else if (environment == PagueVelozEnvironment.Producao)
            {
                return producaoBaseUrl;
            }

            throw new NotImplementedException($"Ambiente {environment.ToString()} não implementado.");
        }

        #region HTTP

        /// <summary>
        /// Realiza um GET na API.
        /// </summary>
        /// <param name="url">Rota da API para requisição.</param>
        /// <returns>O response da requisição.</returns>
        public async Task<HttpResponseMessage> GetAsync(string url) => await _http.GetAsync(url);

        /// <summary>
        /// Realiza um POST na API.
        /// </summary>
        /// <typeparam name="T">O tipo do objeto que será enviado no body da requisição.</typeparam>
        /// <param name="url">Rota da API para requisição.</param>
        /// <param name="content">Um objeto do tipo 'T' que será enviado no body da requisição.</param>
        /// <returns>O response da requisição.</returns>
        public async Task<HttpResponseMessage> PostAsync<T>(string url, T content) => await _http.PostAsync(url, content);

        /// <summary>
        /// Realiza um PUT na API.
        /// </summary>
        /// <typeparam name="T">O tipo do objeto que será enviado no body da requisição.</typeparam>
        /// <param name="url">Rota da API para requisição.</param>
        /// <param name="content">Um objeto do tipo 'T' que será enviado no body da requisição.</param>
        /// <returns>O response da requisição.</returns>
        public async Task<HttpResponseMessage> PutAsync<T>(string url, T content) => await _http.PutAsync(url, content);

        /// <summary>
        /// Realiza um DELETE na API.
        /// </summary>
        /// <param name="url">Rota da API para requisição.</param>
        /// <returns>O response da requisição.</returns>
        public async Task<HttpResponseMessage> DeleteAsync(string url) => await _http.DeleteAsync(url);

        /// <summary>
        /// Trata o response recebido de uma requisição na API.
        /// </summary>
        /// <typeparam name="T">O tipo do objeto que deve retornar da API.</typeparam>
        /// <param name="response">O response a ser tratado.</param>
        /// <returns>Um objeto do tipo 'T' obtido através do response.</returns>
        public async Task<T> NormalizeResponse<T>(HttpResponseMessage response) => await _http.NormalizeResponse<T>(response);

        #endregion

        #region API's

        /// <summary>
        /// Referência para a API de boletos.
        /// </summary>
        public BoletoAPI Boletos { get; }

        #endregion
    }
}
