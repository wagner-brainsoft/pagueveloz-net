using PagueVeloz.Util;
using System.Threading.Tasks;

namespace PagueVeloz.APIs.Boleto
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
            return await _client.PostAsync<EmissaoDTO, RetornoEmissaoDTO>(Url, dto);
        }

        /// <summary>
        /// Busca um boleto pelo id.
        /// </summary>
        /// <param name="id">O id do boleto.</param>
        /// <returns>Informações do boleto.</returns>
        public async Task<ConsultaDTO> ConsultarPorIdAsync(long id)
        {
            return await _client.GetAsync<ConsultaDTO>($"{Url}/{id}");
        }

        /// <summary>
        /// Cancela um boleto.
        /// </summary>
        /// <param name="id">O id do boleto.</param>
        /// <returns>Um bool confirmando o cancelamento.</returns>
        public async Task CancelarAsync(long id)
        {
            await _client.DeleteAsync($"{Url}/{id}");
        }
    }
}
