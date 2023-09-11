using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace api_todo_list_new.Models
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options)
        : base(options) { }

        public DbSet<ToDo> Todos => Set<ToDo>();
    }
}
