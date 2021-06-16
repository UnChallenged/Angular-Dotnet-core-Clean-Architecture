using AngularDotNetCoreCleanArchitecture.Application.Common.Exceptions;
using AngularDotNetCoreCleanArchitecture.Application.TodoLists.Commands.CreateTodoList;
using AngularDotNetCoreCleanArchitecture.Application.TodoLists.Commands.DeleteTodoList;
using AngularDotNetCoreCleanArchitecture.Domain.Entities;
using FluentAssertions;
using NUnit.Framework;
using System.Threading.Tasks;
using static Testing;

namespace AngularDotNetCoreCleanArchitecture.Application.IntegrationTests.TodoLists.Commands
{
    public class DeleteTodoListTests : TestBase
    {
        [Test]
        public void ShouldRequireValidTodoListId()
        {
            var command = new DeleteTodoListCommand { Id = 99 };

            FluentActions.Invoking(() =>
                SendAsync(command)).Should().Throw<NotFoundException>();
        }

        [Test]
        public async Task ShouldDeleteTodoList()
        {
            var listId = await SendAsync(new CreateTodoListCommand
            {
                Title = "New List"
            });

            await SendAsync(new DeleteTodoListCommand
            {
                Id = listId
            });

            var list = await FindAsync<TodoList>(listId);

            list.Should().BeNull();
        }
    }
}
