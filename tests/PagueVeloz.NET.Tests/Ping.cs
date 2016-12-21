using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PagueVeloz.NET.Tests
{
    [TestClass]
    public class Ping : Base
    {
        [TestMethod]
        public void ConsigoPingarAPI()
        {
            Assert.AreEqual("pong", GetClient().GetAsync<string>("api/v1/ping").Result);
        }
    }
}
