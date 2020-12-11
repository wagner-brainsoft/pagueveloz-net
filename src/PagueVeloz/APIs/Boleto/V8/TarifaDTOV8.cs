namespace PagueVeloz.APIs.Boleto.V8
{
    /// <summary>
    /// DTO das tarifas de boleto.
    /// </summary>
    public class TarifaDTOV8
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

    public enum TipoTarifa
    {
        NaoDefinido = 0,
        BoletoEmissao = 1,
        BoletoLiquidacao = 2,
        Saque = 3,
        NaoTarifar = 4,
        TransferenciaEfetuada = 5,
        TransferenciaRecebida = 6,
        DepositoRecebido = 7,
        PagamentoDeConta = 8,
        BoletoBaixaManual = 9,
        DispositivoPINPAD = 10,
        DispositivoPOS = 11,
        DispositivoModerninha = 12,
        OperacaoCartao = 13,
        RecargaCartaoDebito = 14,
        SolicitacaoCartaoDebito = 15,
        RecargaCelular = 16,
        SaqueBanco24Horas = 17,
        PixPagamento = 18,
        PixRecebimento = 19,
        PixRecebimentoQRCodeEstatico = 20,
        PixRecebimentoQRCodeDinamico = 21
    }
}