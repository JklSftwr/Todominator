using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todominator.Core.Domain;
using Todominator.Core.Repository;

namespace Todominator.Repository.Repository
{
    public class TodoRepository : ITodoRepository
    {
        private readonly AppDbContext _context;

        public TodoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<TodoEntry> AddTodoAsync(TodoEntry todo)
        {
            _context.TodoEntries.Add(todo);
            await _context.SaveChangesAsync();

            return todo;
        }

        public async Task<IEnumerable<TodoEntry>> GetTodoListAsync()
        {
            return await _context.TodoEntries.ToListAsync();
        }

        public async Task<TodoEntry> SetTodoDoneAsync(long todoId)
        {
            var todo = await _context.TodoEntries.FirstOrDefaultAsync(x => x.Id == todoId);
            if (todo == null)
            {
                return null;
            }

            todo.IsDone = true;
            await _context.SaveChangesAsync();

            return todo;
        }
    }
}
