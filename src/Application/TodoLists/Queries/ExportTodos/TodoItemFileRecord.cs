using AngularDotNetCoreCleanArchitecture.Application.Common.Mappings;
using AngularDotNetCoreCleanArchitecture.Domain.Entities;

namespace AngularDotNetCoreCleanArchitecture.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
