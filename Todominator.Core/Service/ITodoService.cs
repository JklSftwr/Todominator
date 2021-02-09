using System.Collections.Generic;
using System.Threading.Tasks;
using Todominator.Core.Domain;

namespace Todominator.Core.Service
{
    public interface ITodoService
    {
        public Task<IEnumerable<TodoEntry>> GetTodoListAsync();
        public Task<TodoEntry> AddTodoAsync(TodoEntry todo);
        public Task<TodoEntry> SetTodoDoneAsync(long todoId);
    }
}
