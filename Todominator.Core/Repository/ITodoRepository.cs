using System.Collections.Generic;
using System.Threading.Tasks;
using Todominator.Core.Domain;

namespace Todominator.Core.Repository
{
    public interface ITodoRepository
    {
        public Task<IEnumerable<TodoEntry>> GetTodoListAsync();
        public Task<TodoEntry> AddTodoAsync(TodoEntry todo);
        public Task<TodoEntry> SetTodoDoneAsync(long todoId);
    }
}
