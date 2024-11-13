using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMicroProject.Exception
{
    internal class CustomBookException : SystemException
    {
        public CustomBookException() : base()
        {

        }
        public CustomBookException(string message) : base(message)
        {

        }
    }
}
