using PagueVeloz.NET.Util;
using System.Threading.Tasks;

namespace PagueVeloz.NET.APIs.Boleto
{
    /// <summary>
    /// API para emissão a gerenciamento de boletos.
    /// </summary>
    public class BoletoAPI : BaseAPI
    {
        protected override string Url => "api/v4/boleto";

        public BoletoAPI(PagueVelozClient client) : base(client) { }

        /// <summary>
        /// Emite um novo boleto.
        /// </summary>
        /// <param name="dto">Informações para emissão do boleto.</param>
        /// <returns>Os dados para identificação ao boleto emitido.</returns>
        public async Task<RetornoEmissaoDTO> EmitirAsync(EmissaoDTO dto)
        {
            var response = await _client.PostAsync(Url, dto);
            var normalized = await _client.NormalizeResponse<RetornoEmissaoDTO>(response);

            return normalized;
        }
    }
}
