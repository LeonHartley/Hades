using Hades.Data.MySql.Context;
using Hades.Data.Repositories;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Data.MySql.Repositories
{
    public abstract class RepositoryBase
    {
        public RepositoryBase(MySqlDataContext context)
        {
            Context = context;
        }
       
        public MySqlDataContext Context { get; }

        public MySqlConnection Connection => Context.Connection;
    }
}
