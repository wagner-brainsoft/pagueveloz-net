namespace PagueVeloz.APIs.Boleto
{
    /// <summary>
    /// DTO de retorno da emissão de boletos.
    /// </summary>
    public class RetornoEmissaoDTO
    {
        /// <summary>
        /// O id do boleto emitido.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// A url para acessar o boleto emitido.
        /// </summary>
        public string Url { get; set; }
    }
}