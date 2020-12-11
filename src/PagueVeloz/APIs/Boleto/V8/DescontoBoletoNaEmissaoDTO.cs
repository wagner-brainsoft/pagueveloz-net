using System;
namespace PagueVeloz.APIs.Boleto.V8
{
    public class DescontoBoletoNaEmissaoDTO
    {
        public decimal Valor { get; set; }
        public DateTime DataLimite { get; set; }
        public TipoDescontoBoleto Tipo { get; set; }
    }
    public enum TipoDescontoBoleto
    {
        Isento = 0,
        ValorFixoAteData = 1,
        ValorPercentualAteData = 2,
        ValorAntecipacaoDiaCorrido = 3,
        ValorAntecipacaoDiaUtil = 4,
        PercentualValorNominalDiaCorrido = 5,
        PercentualValorNominalDiaUtil = 6
    }
}