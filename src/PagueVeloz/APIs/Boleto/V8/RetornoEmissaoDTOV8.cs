namespace PagueVeloz.APIs.Boleto.V8
{
    /// <summary>
    /// DTO de retorno da emissão de boletos.
    /// </summary>
    public class RetornoEmissaoDTOV8
    {
        /// <summary>
        /// O id do boleto emitido.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// A url para acessar o boleto emitido.
        /// </summary>
        public string Url { get; set; }

        public string CodigoDeBarras { get; set; }
        
        public string LinhaDigitavel { get; set; }
    }
}