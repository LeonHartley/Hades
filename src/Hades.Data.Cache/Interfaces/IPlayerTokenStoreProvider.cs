using Hades.Data.Cache.Maps;

namespace Hades.Data.Cache.Interfaces
{
    public interface IPlayerTokenStoreProvider
    {
        IPlayerTokenStore GetTokenStore();
    }
}