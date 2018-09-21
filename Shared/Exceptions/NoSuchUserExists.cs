using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Exceptions
{
    public class NoSuchUserExists : Exception
    {
        public NoSuchUserExists()
        : base(String.Format("No such User exists"))
        {

        }
    }
}
