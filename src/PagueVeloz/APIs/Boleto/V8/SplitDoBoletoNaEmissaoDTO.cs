namespace PagueVeloz.APIs.Boleto.V8
{
    public class SplitDoBoletoNaEmissaoDTO
    {
        public string CpfCnpjCliente { get; set; }

        public decimal? ValorFixo { get; set; }

        public decimal? ValorPercentual { get; set; }

        public decimal? ValorTarifaFixo { get; set; }

        public decimal? ValorTarifaPercentual { get; set; }
    }
}