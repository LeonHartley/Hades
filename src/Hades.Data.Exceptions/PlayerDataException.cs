using System;
using Hades.Data.Exceptions.Errors;

namespace Hades.Data.Exceptions
{
    public class PlayerDataException : Exception
    {
        public PlayerDataException(PlayerDataError error)
        {
            Error = error;
        }
        
        public PlayerDataError Error { get; }
    }
}