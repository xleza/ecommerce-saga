using System;
using System.Reflection;

namespace Infrastructure.Exceptions
{
    public sealed class NotFound : Exception
    {
        public NotFound(string id, MemberInfo type) : base($"The resource {type.Name} with identifier {id} not found")
        {

        }
    }
}
