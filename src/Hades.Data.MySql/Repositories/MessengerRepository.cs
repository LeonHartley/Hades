using Hades.Data.MySql.Context;
using Hades.Data.Repositories.Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Data.MySql.Repositories
{
    public class MessengerRepository : RepositoryBase, IMessengerRepository
    {
        public MessengerRepository(MySqlDataContext context) : base(context)
        {
        }
    }
}
