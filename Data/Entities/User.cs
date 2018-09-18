using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class User
    {
        public User()
        {
            this.Todos = new List<Todo>();
        }
        public Guid Id { get; set; }
        public string Email { get; set; } 
        public string Password { get; set; } 

        public virtual ICollection<Todo> Todos { get; set; }
    }
}
