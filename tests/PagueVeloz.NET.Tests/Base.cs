using PagueVeloz.NET.Util;

namespace PagueVeloz.NET.Tests
{
    public class Base
    {
        public PagueVelozClient GetClient()
        {
            var credentials = new PagueVelozCredentials("pv.net.sdk@fake.com.br", "dea081bb-238a-4135-8958-b502a6bef3e8");
            var client = new PagueVelozClient(PagueVelozEnvironment.Sandbox, credentials);

            return client;
        }
    }
}
