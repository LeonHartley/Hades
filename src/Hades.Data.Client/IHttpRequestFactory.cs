using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Hades.Data.Client
{
    public interface IHttpRequestFactory
    {
        HttpRequestMessage CreateRequest(HttpMethod method, string endpoint, string content);
    }
}
