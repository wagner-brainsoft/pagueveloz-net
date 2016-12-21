using PagueVeloz.NET.Util;

namespace PagueVeloz.NET.Tests
{
    public class Base
    {
        private static PagueVelozClient client;

        public PagueVelozClient GetClient()
        {
            if (client == null)
            {
                var credentials = new PagueVelozCredentials("pv.net.sdk@fake.com.br", "dea081bb-238a-4135-8958-b502a6bef3e8");

                client = new PagueVelozClient(PagueVelozEnvironment.Sandbox, credentials);
            }

            return client;
        }
    }
}
