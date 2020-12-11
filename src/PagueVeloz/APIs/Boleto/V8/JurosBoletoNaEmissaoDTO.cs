using System;

namespace PagueVeloz.APIs.Boleto.V8
{
    public class JurosBoletoNaEmissaoDTO
    {
        public TipoJurosBoleto Tipo { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
    }

    public enum TipoJurosBoleto
    {
        ValorPorDia = 1,
        PercentualAoMes = 3,
        Isento = 5
    }
}