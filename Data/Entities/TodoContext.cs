using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Data.Entities
{
    public class TodoContext : DbContext
    {

        public TodoContext() : base("TodoContext")
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Todo> Todos { get; set; }

    }
}
