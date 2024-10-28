using MeetingException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MeetingException
{
    internal class Meeting
    {
        public DateTime FromDate {  get; set; }
        public DateTime ToDate { get; set; }
        public string FullName { get; set; }


        public Meeting(string fullName, DateTime fromDate, DateTime toDate)
        {
            FullName = fullName;
            FromDate = fromDate;
            ToDate = toDate;
        }
    }
}


//Meeting class:
//-FromDate
//-ToDate
//-FullName


//MeetingSchedule class:
//Meetings - Meeting array-ı
//SetMeeting(fullname, from, to) - gonderilmis deyerlere esasen meeting yaratmaga calisir.Eger Gonderilmis tarix intervalinda meeting varsa geriye ReservedDateInterval exception qaytarir, eger gonderilen fromdate todate-den kicik deyilse WrongDateInterval exception qaytarir, her sey okaydirse meeting obyekti yaradib meeting listine add edir