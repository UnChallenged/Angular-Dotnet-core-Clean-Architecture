using AngularDotNetCoreCleanArchitecture.Domain.Common;
using AngularDotNetCoreCleanArchitecture.Domain.ValueObjects;
using System.Collections.Generic;

namespace AngularDotNetCoreCleanArchitecture.Domain.Entities
{
    public class TodoList : AuditableEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public Colour Colour { get; set; } = Colour.White;

        public IList<TodoItem> Items { get; private set; } = new List<TodoItem>();
    }
}
