using System;
using System.Collections.Generic;
using System.Text;
using Hades.Data.Exceptions.Errors;

namespace Hades.Data.Exceptions
{
    public class PlayerAuthenticationException : Exception
    {
        public PlayerAuthenticationException(PlayerAuthenticationError error)
        {
            Error = error;
        }
        
        public PlayerAuthenticationError Error { get; }
    }
}
