using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Data.MySql
{
    public interface IConnectionStringProvider
    {
        string ConnectionString { get; }
    }
}
