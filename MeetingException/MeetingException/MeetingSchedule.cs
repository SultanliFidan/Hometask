using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MeetingException
{
    internal class MeetingSchedule
    {
        public Meeting[] Meetings ;
        public MeetingSchedule()
        {
                Meetings = new Meeting[0];
        }
        public void SetMeeting(string fullname, DateTime from, DateTime to)
        {
            if (from >= to)
            {
                throw new WrongDateIntervalException();
            }


            foreach (Meeting meeting in Meetings)
            {
                if (to > meeting.FromDate && from < meeting.ToDate) 
                {
                    throw new ReservedDateIntervalException();
                }
            }

          

            Array.Resize(ref Meetings, Meetings.Length + 1);


            Meetings[Meetings.Length - 1] = new Meeting(fullname,from,to);
        }
    }
}
