using System;

namespace Hades.Gateway.Core
{
    public sealed class HadesGatewayOptions
    {
        public string GatewayId { get; set; }

        public string Host { get; set; }

        public short Port { get; set; }

        public string HttpApiUrl { get; set; }

        public string HttpApiSecret { get; set; }
    }
}
