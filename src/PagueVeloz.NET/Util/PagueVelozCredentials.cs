using System;
using System.Text;

namespace PagueVeloz.NET.Util
{
    /// <summary>
    /// Autenticador para as requisições feitas nas API's PagueVeloz.
    /// </summary>
    public class PagueVelozCredentials
    {
        private readonly string _email;
        private readonly string _token;

        /// <summary>
        /// Inicializador do autenticador.
        /// </summary>
        /// <param name="email">O e-mail de cadastro do cliente.</param>
        /// <param name="token">O token de integração (é enviado por e-mail no momento do cadastro).</param>
        public PagueVelozCredentials(string email, string token)
        {
            _email = email;
            _token = token;
        }

        /// <summary>
        /// O base64 gerado a partir do email:token.
        /// </summary>
        public string TokenBase64 => Convert.ToBase64String(Encoding.Default.GetBytes($"{_email}:{_token}"));

        /// <summary>
        /// O conteúdo para o header 'Authorization' das requisições.
        /// </summary>
        public string Authorization => $"Basic {TokenBase64}";
    }
}
