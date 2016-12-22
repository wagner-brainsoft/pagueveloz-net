using Xunit;

namespace PagueVeloz.Tests
{
    
    public class Ping : Base
    {
        [Fact]
        public void Ping_ConsigoPingar()
        {
            Assert.Equal("pong", GetClient().GetAsync<string>("api/v1/ping").Result);
        }
    }
}
