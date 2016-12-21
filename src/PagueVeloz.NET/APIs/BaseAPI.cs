using PagueVeloz.NET.Util;

namespace PagueVeloz.NET.APIs
{
    public abstract class BaseAPI
    {
        protected readonly PagueVelozClient _client;

        protected abstract string Url { get; }

        public BaseAPI(PagueVelozClient client)
        {
            _client = client;
        }
    }
}
