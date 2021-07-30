using System;

namespace Infrastructure.Exceptions
{
    public class BadRequest : Exception
    {
        public BadRequest(string message = null) : base(message)
        {

        }
    }
}
