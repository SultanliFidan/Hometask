using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Exceptions
{
    internal class UsernameAlreadyExist :Exception
    {
        public UsernameAlreadyExist() : base() { }
        public UsernameAlreadyExist(string message) : base(message) { }
    }
}
