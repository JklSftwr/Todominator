using Microsoft.EntityFrameworkCore;
using Todominator.Core.Domain;

namespace Todominator.Repository
{
    public class AppDbContext : DbContext
    {
        public DbSet<TodoEntry> TodoEntries { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
