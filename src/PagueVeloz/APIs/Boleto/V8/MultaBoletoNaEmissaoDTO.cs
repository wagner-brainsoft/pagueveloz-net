using System;

namespace PagueVeloz.APIs.Boleto.V8
{
    public class MultaBoletoNaEmissaoDTO
    {
        public TipoMultaBoleto Tipo { get; set; }

        public decimal Valor { get; set; }

        public DateTime Data { get; set; }
    }

    public enum TipoMultaBoleto
    {
        ValorFixo = 1,
        Percentual = 2,
        Isento = 3,
    }
}