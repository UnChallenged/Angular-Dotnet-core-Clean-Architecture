using AngularDotNetCoreCleanArchitecture.Application.Common.Interfaces;
using System;

namespace AngularDotNetCoreCleanArchitecture.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
