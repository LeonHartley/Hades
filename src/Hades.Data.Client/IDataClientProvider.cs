using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Hades.Data.Client
{
    public interface IDataClientProvider
    {
        IDataClient GetClient();
    }
}