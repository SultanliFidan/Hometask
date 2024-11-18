using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Exceptions
{
    internal class ProductNotFoundException : Exception
    {
        public ProductNotFoundException() : base() { }
        public ProductNotFoundException(string message) : base(message) { }
    }
}
