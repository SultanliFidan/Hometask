using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalClass.Exception
{
    class HospitalException : System.Exception
    {
        public HospitalException() : base() { }

        public HospitalException(string message) : base(message) { }
    }
}
