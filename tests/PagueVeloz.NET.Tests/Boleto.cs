using Microsoft.VisualStudio.TestTools.UnitTesting;
using PagueVeloz.NET.APIs.Boleto;
using System;

namespace PagueVeloz.NET.Tests
{
    [TestClass]
    public class Boleto : Base
    {
        private RetornoEmissaoDTO Emitir()
        {
            var emissao = new EmissaoDTO()
            {
                Sacado = "Joãozinho",
                CPFCNPJSacado = "460.844.654-12",
                Valor = 100m,
                Vencimento = DateTime.Today.AddDays(10)
            };

            return GetClient().Boletos.EmitirAsync(emissao).Result;
        }

        [TestMethod]
        public void Boleto_ConsigoEmitirComOsCamposMinimos()
        {
            var retorno = Emitir();

            Assert.IsNotNull(retorno);
            Assert.IsTrue(retorno.Id > 0);
            Assert.IsFalse(string.IsNullOrWhiteSpace(retorno.Url));
        }

        [TestMethod]
        public void Boleto_ConsigoConsultarPeloId()
        {
            var retorno = Emitir();

            Assert.IsNotNull(retorno);
            Assert.IsTrue(retorno.Id > 0);

            var boleto = GetClient().Boletos.ConsultarPorIdAsync(retorno.Id).Result;

            Assert.IsNotNull(boleto);
            Assert.AreEqual(retorno.Id, boleto.Id);
            Assert.AreEqual(retorno.Url, boleto.Url);
            Assert.AreEqual("Joãozinho", boleto.Sacado);
            Assert.AreEqual("460.844.654-12", boleto.Documento);
            Assert.AreEqual(100m, boleto.Valor);
            Assert.AreEqual(DateTime.Today.AddDays(10), boleto.Vencimento);
        }

        [TestMethod]
        public void Boleto_ConsigoCancelar()
        {
            var retorno = Emitir();

            Assert.IsNotNull(retorno);
            Assert.IsTrue(retorno.Id > 0);

            var boleto = GetClient().Boletos.ConsultarPorIdAsync(retorno.Id).Result;

            Assert.IsNotNull(boleto);
            Assert.IsFalse(boleto.Cancelado);

            GetClient().Boletos.CancelarAsync(boleto.Id).Wait();

            boleto = GetClient().Boletos.ConsultarPorIdAsync(retorno.Id).Result;

            Assert.IsNotNull(boleto);
            Assert.IsTrue(boleto.Cancelado);
        }
    }
}
