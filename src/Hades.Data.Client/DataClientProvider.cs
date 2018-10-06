using Hades.Data.Client.Players;

namespace Hades.Data.Client
{
    public class DataClientProvider : IDataClientProvider
    {
        private readonly DataClientOptions _clientOptions;
        private readonly IHttpRequestFactory _requestFactory;
        
        public DataClientProvider(DataClientOptions clientOptions, IHttpRequestFactory requestFactory)
        {
            _clientOptions = clientOptions;
            _requestFactory = requestFactory;
        }
        
        public IDataClient GetClient()
        {
            return new DataClient(_clientOptions)
            {
                Player = new PlayerClient(_clientOptions, _requestFactory)
            };
        }
    }
}