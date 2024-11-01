using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalClass.Models
{
    internal class Appointment
    {
        private static int _no;
        public int No { get; }
        public string Patient { get; set; }
        public string Doctor { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        public Appointment(string patient,string doctor,DateTime startDate, DateTime endDate)
        {
                Patient = patient;
                Doctor = doctor;
                StartDate = startDate;
                EndDate = endDate;


            No = ++_no;
        }
    }
}
