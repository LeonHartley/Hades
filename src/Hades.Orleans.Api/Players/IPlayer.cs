using Hades.Orleans.Api.Players.Messenger;
using Orleans;
using System;
using System.Threading.Tasks;

namespace Hades.Orleans.Api.Players
{
    public interface IPlayer : IGrainWithStringKey 
    {
        Task<PlayerData> Data();
    }
}
