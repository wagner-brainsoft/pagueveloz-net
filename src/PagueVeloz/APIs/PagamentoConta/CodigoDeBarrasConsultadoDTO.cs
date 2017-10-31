using System;

namespace PagueVeloz.APIs.PagamentoConta
{
    /// <summary>
    /// DTO de retorno das consultas de código de barras para pagamento.
    /// </summary>
    public class CodigoDeBarrasConsultadoDTO
    {
        public long Id { get; set; }
        public bool PodeSerPago { get; set; }
        public string Observacao { get; set; }
        public DadosDto Dados { get; set; }

        public class PessoaDto
        {
            public string CpfOuCnpj { get; set; }
            public string NomeOuRazao { get; set; }
        }

        public class DadosDto
        {
            public string Banco { get; set; }
            public bool Registrado { get; set; }
            public decimal? Valor { get; set; }
            public decimal? ValorMinimo { get; set; }
            public decimal? ValorMaximo { get; set; }
            public DateTime? DataVencimento { get; set; }
            public DateTime? DataLimiteParaPagamento { get; set; }
            public PessoaDto Pagador { get; set; }
            public PessoaDto BeneficiarioOriginal { get; set; }
            public PessoaDto BeneficiarioFinal { get; set; }
        }
    }
}
