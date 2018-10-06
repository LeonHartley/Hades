using System;
using System.Collections.Generic;
using System.Text;

namespace Hades.Data.Exceptions
{
    public class PlayerAuthenticationException : Exception
    {
        public PlayerAuthenticationException(string message) : base(message)
        {
        }
    }
}
