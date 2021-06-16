using AngularDotNetCoreCleanArchitecture.Domain.Common;
using AngularDotNetCoreCleanArchitecture.Domain.Entities;

namespace AngularDotNetCoreCleanArchitecture.Domain.Events
{
    public class TodoItemCompletedEvent : DomainEvent
    {
        public TodoItemCompletedEvent(TodoItem item)
        {
            Item = item;
        }

        public TodoItem Item { get; }
    }
}
