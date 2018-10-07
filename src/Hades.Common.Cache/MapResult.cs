using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Common.Cache
{
    public class MapResult<T>
    {
        public MapResult(bool hasValue, T val)
        {
            HasValue = hasValue;
            Result = val;
        }

        public bool HasValue { get; }

        public T Result { get; }
    }
}
