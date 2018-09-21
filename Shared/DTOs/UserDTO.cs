using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.DTOs
{
    public class UserDTO
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
