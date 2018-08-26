using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Hades.Data.Client
{
    public class ServiceClient : IServiceClient
    {
        private readonly DataClientOptions _dataClientOptions;
        private readonly IHttpRequestFactory _requestFactory;

        public ServiceClient(DataClientOptions dataClientOptions, IHttpRequestFactory requestFactory)
        {
            _dataClientOptions = dataClientOptions;
            _requestFactory = requestFactory;
        }

        public async Task<T> Get<T>(string endpoint)
        {
            var message = _requestFactory.CreateRequest(HttpMethod.Get, endpoint, "");

            using (HttpClient httpClient = new HttpClient())
            {
                var result = await httpClient.SendAsync(message);
                var data = await result.Content.ReadAsStringAsync();

                if(!string.IsNullOrEmpty(data))
                {
                    return JsonConvert.DeserializeObject<T>(data);
                }
            }

            return default(T);
        }
    }
}
