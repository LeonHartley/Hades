using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Hades.Data.Client
{
    public class HttpRequestFactory : IHttpRequestFactory
    {
        private readonly DataClientOptions _dataClientOptions;

        public HttpRequestFactory(DataClientOptions dataClientOptions)
        {
            _dataClientOptions = dataClientOptions;
        }

        public HttpRequestMessage CreateRequest(HttpMethod method, string endpoint, string content)
        {
            var message = new HttpRequestMessage(method,
                string.Format("{0}/{1}/{2}", _dataClientOptions.HttpApiUrl, "v1", endpoint));

            message.Headers.Add("X-Hades-Authorization", _dataClientOptions.HttpApiSecret);
            message.Content = new StringContent(content, Encoding.UTF8, "application/json");

            return message;
        }
    }
}
