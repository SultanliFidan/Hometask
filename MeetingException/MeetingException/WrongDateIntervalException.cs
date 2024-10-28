using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingException
{
    class WrongDateIntervalException : Exception
    {
        public WrongDateIntervalException() : base("fromdate todate-den kicik deyil") { }
    }
}
