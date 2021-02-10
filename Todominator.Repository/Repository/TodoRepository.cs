using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Todominator.Core.Domain;
using Todominator.Core.Repository;

namespace Todominator.Repository.Repository
{
    public class TodoRepository : ITodoRepository
    {
        public Task<TodoEntry> AddTodoAsync(TodoEntry todo)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TodoEntry>> GetTodoListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TodoEntry> SetTodoDoneAsync(long todoId)
        {
            throw new NotImplementedException();
        }
    }
}
