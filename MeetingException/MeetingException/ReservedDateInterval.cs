using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingException
{
    class ReservedDateIntervalException : Exception
    {
        public ReservedDateIntervalException() : base("Gonderilmis tarix intervalinda meeting var") { }
    }
}
