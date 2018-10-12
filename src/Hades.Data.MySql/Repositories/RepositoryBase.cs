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
        protected RepositoryBase(MySqlDataContext context)
        {
            Context = context;
        }

        private MySqlDataContext Context { get; }

        protected MySqlConnection Connection => Context.Connection;
    }
}
