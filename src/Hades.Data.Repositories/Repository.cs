using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Data.Repositories
{
    public class Repository
    {
        public Repository(int instanceId)
        {
            InstanceId = instanceId;
        }

        public int InstanceId { get; }
    }
}
