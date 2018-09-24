using System;
using System.Collections.Generic;
using System.Text;

namespace TodoData.Entities
{
    public class User
    {
        public User()
        {
            this.Todo = new List<Todo>();
        }
        public Guid Id { get; set; }
        public string UserName { get; set; } 
        public string Password { get; set; } 

        public virtual ICollection<Todo> Todo { get; set; }
    }
}
