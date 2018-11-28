// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserDomainException.cs" company="Axity">
//   Axity
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Axity.Project.ServiceName.Infrastructure.Exceptions
{
    using System;

    public class UserDomainException : Exception
    {
        public UserDomainException()
        { }

        public UserDomainException(string message)
            : base(message)
        { }

        public UserDomainException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
