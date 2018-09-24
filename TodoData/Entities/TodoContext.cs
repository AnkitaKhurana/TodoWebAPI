using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace TodoData.Entities
{
    public class TodoContext : DbContext
    {

        public TodoContext() : base("TodoContext")
        {
        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Todo> Todos { get; set; }

    }
}
