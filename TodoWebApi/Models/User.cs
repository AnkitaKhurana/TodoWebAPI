using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoWebApi.Models
{
    public class User
    {
      
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}