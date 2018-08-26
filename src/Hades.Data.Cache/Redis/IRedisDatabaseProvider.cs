using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Data.Cache
{
    public interface IRedisDatabaseProvider
    {
        IDatabaseAsync GetDatabase();
    }
}
