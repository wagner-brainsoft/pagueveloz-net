using PagueVeloz.Util;
using System.Threading.Tasks;

namespace PagueVeloz.APIs.PagamentoConta
{
    /// <summary>
    /// API para pagamento de contas.
    /// </summary>
    public class PagamentoContaAPI : BaseAPI
    {
        protected override string Url => "api/v3/conta";

        public PagamentoContaAPI(PagueVelozClient client) : base(client) { }

        /// <summary>
        /// Consulta um código de barras para pagamento.
        /// </summary>
        /// <param name="codigoDeBarras">Código de barras.</param>
        /// <returns>Retorna os dados do código de barras.</returns>
        public async Task<CodigoDeBarrasConsultadoDTO> ConsultarCodigoDeBarrasAsync(string codigoDeBarras)
        {
            return await _client.GetAsync<CodigoDeBarrasConsultadoDTO>($"{Url}/barras?codigo={codigoDeBarras}");
        }
    }
}
