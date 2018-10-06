using System.Threading.Tasks;
using Hades.Data.Model.Players;

namespace Hades.Data.Client.Players
{
    public class PlayerClient : ServiceClient, IPlayerClient
    {
        public PlayerClient(DataClientOptions dataClientOptions, IHttpRequestFactory requestFactory) : base(
            dataClientOptions, requestFactory)
        {
        }

        public async Task<Player> Authenticate(string ssoTicket)
        {
            return await Get<Player>(string.Format("players/authenticate/{0}", ssoTicket));
        }
    }
}