using System.Collections.Generic;
using System.Threading.Tasks;
using Todominator.Core.Domain;
using Todominator.Core.Service;

namespace Todominator.Business.Service
{
    public class TodoService : ITodoService
    {
        private readonly ITodoService _service;

        public TodoService(ITodoService service)
        {
            _service = service;
        }

        public async Task<TodoEntry> AddTodoAsync(TodoEntry todo)
        {
            return await _service.AddTodoAsync(todo);
        }

        public async Task<IEnumerable<TodoEntry>> GetTodoListAsync()
        {
            return await _service.GetTodoListAsync();
        }

        public async Task<TodoEntry> SetTodoDoneAsync(long todoId)
        {
            return await _service.SetTodoDoneAsync(todoId);
        }
    }
}
