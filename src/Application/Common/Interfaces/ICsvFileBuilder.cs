using AngularDotNetCoreCleanArchitecture.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace AngularDotNetCoreCleanArchitecture.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
