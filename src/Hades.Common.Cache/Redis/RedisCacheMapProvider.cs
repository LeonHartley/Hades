namespace Hades.Common.Cache.Redis
{
    public class RedisCacheMapProvider : ICacheMapProvider
    {
        private readonly IRedisDatabaseProvider _databaseProvider;

        public RedisCacheMapProvider(IRedisDatabaseProvider databaseProvider)
        {
            _databaseProvider = databaseProvider;
        }
        
        public ICacheMap<TKey, TVal> GetMap<TKey, TVal>(string name)
        {
            return new RedisCacheMap<TKey, TVal>(name, _databaseProvider.GetDatabase());
        }
    }
}