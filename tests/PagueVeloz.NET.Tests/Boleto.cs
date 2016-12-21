using Microsoft.VisualStudio.TestTools.UnitTesting;
using PagueVeloz.NET.APIs.Boleto;
using System;

namespace PagueVeloz.NET.Tests
{
    [TestClass]
    public class Boleto : Base
    {
        [TestMethod]
        public void ConsigoEmitirComOsCamposMinimos()
        {
            var emissao = new EmissaoDTO()
            {
                Sacado = "Robson da Silva",
                CPFCNPJSacado = "085.986.159-78",
                Valor = 100m,
                Vencimento = DateTime.Today.AddDays(10)
            };

            var retorno = GetClient().Boletos.EmitirAsync(emissao).Result;

            Assert.IsTrue(retorno.Id > 0);
            Assert.IsFalse(string.IsNullOrWhiteSpace(retorno.Url));
        }
    }
}
