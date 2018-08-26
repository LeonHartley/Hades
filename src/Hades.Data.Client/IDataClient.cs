using Hades.Data.Client.Players;
using System;

namespace Hades.Data.Client
{
    public interface IDataClient
    {
        IPlayerClient Player { get; set; }
    }
}
