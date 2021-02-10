using System.Collections.Generic;
using System.Threading.Tasks;
using Todominator.Core.Domain;
using Todominator.Core.Repository;
using Todominator.Core.Service;

namespace Todominator.Business.Service
{
    public class TodoService : ITodoService
    {
        private readonly ITodoRepository _repository;

        public TodoService(ITodoRepository repository)
        {
            _repository = repository;
        }

        public async Task<TodoEntry> AddTodoAsync(TodoEntry todo)
        {
            return await _repository.AddTodoAsync(todo);
        }

        public async Task<IEnumerable<TodoEntry>> GetTodoListAsync()
        {
            return await _repository.GetTodoListAsync();
        }

        public async Task<TodoEntry> SetTodoDoneAsync(long todoId)
        {
            return await _repository.SetTodoDoneAsync(todoId);
        }
    }
}
