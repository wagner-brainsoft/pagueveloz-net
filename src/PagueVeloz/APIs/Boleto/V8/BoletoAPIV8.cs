using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using PagueVeloz.Util;

namespace PagueVeloz.APIs.Boleto.V8
{
    /// <summary>
    /// API para emissão a gerenciamento de boletos.
    /// </summary>
    public class BoletoAPIV8: BaseAPI
    {
        protected override string Url => "api/v8/boleto";

        public BoletoAPIV8(PagueVelozClient client) : base(client) { }

        /// <summary>
        /// Emite um novo boleto.
        /// </summary>
        /// <param name="dto">Informações para emissão do boleto.</param>
        /// <param name="cancellationToken">Token de cancelamento.</param>
        /// <returns>Os dados para identificação ao boleto emitido.</returns>
        public async Task<RetornoEmissaoDTOV8> EmitirAsync(EmissaoBoletoV8DTO dto, CancellationToken cancellationToken = default)
        {
            return await _client.PostAsync<EmissaoBoletoV8DTO, RetornoEmissaoDTOV8>(Url, dto, cancellationToken);
        }

        /// <summary>
        /// Busca um boleto pelo id.
        /// </summary>
        /// <param name="id">O id do boleto.</param>
        /// <param name="cancellationToken">Token de cancelamento.</param>
        /// <returns>Informações do boleto.</returns>
        public async Task<ItemRelatorioBoletoDTO> ConsultarPorIdAsync(long id, CancellationToken cancellationToken = default)
        {
            return await _client.GetAsync<ItemRelatorioBoletoDTO>($"{Url}/{id}", cancellationToken);
        }
        
        public async Task<IList<ItemRelatorioBoletoDTO>> ConsultarPorSeuNumeroAsync(string seuNumero, CancellationToken cancellationToken = default)
        {
            return await _client.GetAsync<IList<ItemRelatorioBoletoDTO>>($"{Url}?SeuNumero={seuNumero}", cancellationToken);
        }

        /// <summary>
        /// Cancela um boleto.
        /// </summary>
        /// <param name="id">O id do boleto.</param>
        /// <param name="cancellationToken">Token de cancelamento.</param>
        /// <returns>Um bool confirmando o cancelamento.</returns>
        public async Task CancelarAsync(long id, CancellationToken cancellationToken = default)
        {
            await _client.DeleteAsync($"{Url}/{id}", cancellationToken);
        }
    }
}