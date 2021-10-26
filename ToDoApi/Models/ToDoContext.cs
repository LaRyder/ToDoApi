using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ToDoApi.Models
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options)
                : base(options)
        {
           // services.AddDbContext<ToDoContext>(options =>
               // options.UseInMemoryDatabase("ToDoList"));
        }

        public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}
