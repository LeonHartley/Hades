using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Data.MySql
{
    public interface IConnectionProvider
    {
        MySqlConnection GetConnection();
    }
}
