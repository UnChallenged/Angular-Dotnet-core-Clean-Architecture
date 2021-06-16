using AngularDotNetCoreCleanArchitecture.Domain.Common;
using AngularDotNetCoreCleanArchitecture.Domain.Entities;

namespace AngularDotNetCoreCleanArchitecture.Domain.Events
{
    public class TodoItemCreatedEvent : DomainEvent
    {
        public TodoItemCreatedEvent(TodoItem item)
        {
            Item = item;
        }

        public TodoItem Item { get; }
    }
}
