using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Hades.Data.WebApi.Model
{
    public class ServerResponse<T>
    {
        [JsonProperty("data")]
        public T Data { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public dynamic Error { get; set; }
    }
}
