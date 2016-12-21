using System;

namespace PagueVeloz.NET.APIs.Boleto
{
    /// <summary>
    /// DTO utilizado para emissão de boletos.
    /// </summary>
    public class EmissaoDTO
    {
        /// <summary>
        /// [Obrigatório] O nome do sacado.
        /// </summary>
        public string Sacado { get; set; }

        /// <summary>
        /// [Obrigatório] O CPF ou CNPJ do sacado.
        /// </summary>
        public string CPFCNPJSacado { get; set; }

        /// <summary>
        /// [Obrigatório] A data de vencimento do boleto.
        /// </summary>
        public DateTime Vencimento { get; set; }

        /// <summary>
        /// [Obrigatório] O valor do boleto.
        /// </summary>
        public decimal Valor { get; set; }

        /// <summary>
        /// Um identificador único para o boleto.
        /// </summary>
        public string SeuNumero { get; set; }

        /// <summary>
        /// Um identificador para a parcela à qual o boleto se refere.
        /// </summary>
        public string Parcela { get; set; }

        /// <summary>
        /// Primeira linha de observações do boleto.
        /// </summary>
        public string Linha1 { get; set; }

        /// <summary>
        /// Segunda linha de observações do boleto.
        /// </summary>
        public string Linha2 { get; set; }

        /// <summary>
        /// Um e-mail para envio do boleto após a emissão.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// A data e hora para envio do e-mail. Se null e o campo 'Email' for informado, o e-mail será enviado logo após a emissão.
        /// </summary>
        public DateTime? DataEnvioEmail { get; set; }

        /// <summary>
        /// Define se deve ser gerado um PDF para o boleto ou se ele será acessado apenas através do link.
        /// </summary>
        public bool Pdf { get; set; }
    }
}