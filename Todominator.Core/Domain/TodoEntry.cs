using System;

namespace Todominator.Core.Domain
{
    public class TodoEntry
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsDone { get; set; }
    }
}
