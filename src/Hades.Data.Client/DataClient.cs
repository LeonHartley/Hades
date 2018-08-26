using System;
using System.Collections.Generic;
using System.Text;
using Hades.Data.Client.Players;

namespace Hades.Data.Client
{
    public class DataClient : IDataClient
    {
        public DataClient(DataClientOptions clientOptions)
        {
            ClientOptions = clientOptions;
        }

        public IPlayerClient Player { get; set; }

        private DataClientOptions ClientOptions { get; }
    }
}
