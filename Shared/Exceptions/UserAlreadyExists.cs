using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Exceptions
{
    public class UserAlreadyExists : Exception
    {
        public UserAlreadyExists()
        : base(String.Format("UserName Already Exists"))
        {

        }
    }
   
}
