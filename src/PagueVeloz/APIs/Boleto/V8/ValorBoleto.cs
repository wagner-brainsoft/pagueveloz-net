namespace PagueVeloz.APIs.Boleto.V8
{
    public class ValorBoleto
    {
        public TipoDescontoBoleto Tipo { get; set; }
        public decimal Valor { get; set; }
    }

    public enum TipoValorBoleto
    {
        Percentual = 80,
        ValorFixo = 86
    }
}