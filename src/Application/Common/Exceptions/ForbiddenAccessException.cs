using System;

namespace AngularDotNetCoreCleanArchitecture.Application.Common.Exceptions
{
    public class ForbiddenAccessException : Exception
    {
        public ForbiddenAccessException() : base() { }
    }
}
