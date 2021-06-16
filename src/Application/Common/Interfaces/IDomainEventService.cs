using AngularDotNetCoreCleanArchitecture.Domain.Common;
using System.Threading.Tasks;

namespace AngularDotNetCoreCleanArchitecture.Application.Common.Interfaces
{
    public interface IDomainEventService
    {
        Task Publish(DomainEvent domainEvent);
    }
}
