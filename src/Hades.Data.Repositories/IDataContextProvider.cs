using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Data.Repositories
{
    public interface IDataContextProvider
    {
        IDataContext GetContext();
    }
}
