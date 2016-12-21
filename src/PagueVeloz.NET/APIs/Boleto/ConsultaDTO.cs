using System;
using System.Collections.Generic;

namespace PagueVeloz.NET.APIs.Boleto
{
    /// <summary>
    /// DTO de retorno das consultas de boletos.
    /// </summary>
    public class ConsultaDTO
    {
        /// <summary>
        /// O id do boleto.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// O nome do sacado.
        /// </summary>
        public string Sacado { get; set; }

        /// <summary>
        /// O documento (CPF/CNPJ) do sacado.
        /// </summary>
        public string Documento { get; set; }

        /// <summary>
        /// A data de emissão.
        /// </summary>
        public DateTime Emissao { get; set; }

        /// <summary>
        /// A data de vencimento.
        /// </summary>
        public DateTime Vencimento { get; set; }

        /// <summary>
        /// A data do último pagamento efetuado.
        /// </summary>
        public DateTime? DataPagamento { get; set; }

        /// <summary>
        /// A data para envio do e-mail com o boleto.
        /// </summary>
        public DateTime? DataEnvioEmail { get; set; }

        /// <summary>
        /// O valor do boleto emitido.
        /// </summary>
        public decimal Valor { get; set; }

        /// <summary>
        /// A soma dos valores de pagamentos efetuados para o boleto.
        /// </summary>
        public decimal ValorPago { get; set; }

        /// <summary>
        /// O valor pago descontando as tarifas cobradas.
        /// </summary>
        public decimal ValorLiquido { get; set; }

        /// <summary>
        /// Um identificador informado pelo cliente emissor do boleto.
        /// </summary>
        public string SeuNumero { get; set; }

        /// <summary>
        /// O identificador do boleto no banco emissor.
        /// </summary>
        public string NossoNumero { get; set; }

        /// <summary>
        /// O identificador de parcela informado pelo cliente emissor do boleto.
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
        /// A url para acessar o boleto.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// O e-mail para envio do boleto.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Flag para indicar se o boleto foi cancelado.
        /// </summary>
        public bool Cancelado { get; set; }

        /// <summary>
        /// Indica a quantidade de pagamentos efetuados para o boleto.
        /// </summary>
        public int QuantidadePagamentos { get; set; }

        /// <summary>
        /// Lista as tarifas cobradas pelo boleto.
        /// </summary>
        public IList<TarifaDTO> TarifasCobradas { get; set; }

        /// <summary>
        /// DTO das tarifas de boleto.
        /// </summary>
        public class TarifaDTO
        {
            /// <summary>
            /// O valor da tarifa cobrada.
            /// </summary>
            public decimal Valor { get; set; }

            /// <summary>
            /// O tipo da tarifa.
            /// </summary>
            public Enums.TipoTarifa Tipo { get; set; }
        }
    }
}
