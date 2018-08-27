using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Hades.Data.Models.Players;

namespace Hades.Data.Client.Players
{
    public class PlayerClient : ServiceClient, IPlayerClient
    {
        public PlayerClient(DataClientOptions dataClientOptions, IHttpRequestFactory requestFactory) : base(dataClientOptions, requestFactory)
        {
        }

        public Task<Player> Authenticate(string ssoTicket)
        {
            return Get<Player>(string.Format("players/authenticate/{0}", ssoTicket));
        }
    }
}
