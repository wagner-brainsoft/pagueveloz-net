using System;
using System.Collections.Generic;

namespace PagueVeloz.APIs.Boleto.V8
{
    /// <summary>
    /// DTO de retorno das consultas de boletos.
    /// </summary>
    public class ItemRelatorioBoletoDTO
    {
        /// <summary>
        /// Um identificador informado pelo cliente emissor do boleto.
        /// </summary>
        public string SeuNumero { get; set; }
        
        /// <summary>
        /// A data de vencimento.
        /// </summary>
        public DateTime Vencimento { get; set; }

        /// <summary>
        /// Indica se o boleto está vencido
        /// </summary>
        public bool EstaVencido { get; set; }

        /// <summary>
        /// O documento (CPF/CNPJ) do sacado.
        /// </summary>
        public string Documento { get; set; }

        /// <summary>
        /// O nome do sacado.
        /// </summary>
        public string Sacado { get; set; }
        
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

        public decimal ValorEmBaixaOperacional { get; set; }

        /// <summary>
        /// Lista as tarifas cobradas pelo boleto.
        /// </summary>
        public IList<TarifaDTOV8> TarifasCobradas { get; set; }

        public bool TemPagamento { get; set; }
        
        /// <summary>
        /// A url para acessar o boleto.
        /// </summary>
        public string Url { get; set; }
        
        public string Linha1 { get; set; }
        
        public string Linha2 { get; set; }

        /// <summary>
        /// Flag para indicar se o boleto foi cancelado.
        /// </summary>
        public bool Cancelado { get; set; }

        public int QuantidadeVisualizacoes { get; set; }

        public bool QuantidadeRejeicoes { get; set; }

        /// <summary>
        /// Indica a quantidade de pagamentos efetuados para o boleto.
        /// </summary>
        public int QuantidadePagamentos { get; set; }

        /// <summary>
        /// O e-mail para envio do boleto.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// O identificador do boleto no banco emissor.
        /// </summary>
        public string NossoNumero { get; set; }

        /// <summary>
        /// O identificador de parcela informado pelo cliente emissor do boleto.
        /// </summary>
        public string Parcela { get; set; }

        /// <summary>
        /// A data de emissão.
        /// </summary>
        public DateTime Emissao { get; set; }

        public string CodigoBarras { get; set; }
        
        public string LinhaDigitavel { get; set; }

        public DateTime DataRegistro { get; set; }
        
        /// <summary>
        /// O id do boleto.
        /// </summary>
        public long Id { get; set; }
    }
}
