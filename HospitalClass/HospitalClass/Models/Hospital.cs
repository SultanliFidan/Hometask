using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace HospitalClass.Models;

internal class Hospital
{
    private List<Appointment> Appointments = new List<Appointment>();

    public void AddAppointment(Appointment appointment)
    {
        Appointments.Add(appointment);
        
    }
    public void EndAppointment(int no)
    {
        Appointment appointment = Appointments.Find(x => x.No == no);
        if (appointment != null)
        {
            appointment.EndDate = DateTime.Now;
            throw new System.Exception("Appointment bitirildi.");
        }
        else
        {
            throw new System.Exception("Appointment tapilmadi.");
        }
    }
    public Appointment GetAppointment(int no)
    {
        Appointment appointment = Appointments.Find(x => x.No == no);
        if (appointment != null)
        {
            throw new System.Exception("No-a uygun appointment tapilmadi");
        }
        return appointment;
    }

    public List<Appointment> GetAllAppointments()
    {
        return Appointments;
    }
    public List<Appointment> GetWeeklyAppointments()
    {
        DateTime startOfWeek = DateTime.Now;
        DateTime endOfWeek = startOfWeek.AddDays(-7);
        List<Appointment> weekly = Appointments.FindAll(a => a.StartDate >= DateTime.Now.AddDays(-7));
        return weekly;
    }
    public List<Appointment> GetTodaysAppointments()
    {
        DateTime today = DateTime.Now.Date;
        List<Appointment> daily = Appointments.FindAll(a => a.StartDate.Date == today);
        return daily;
    }
    public List<Appointment> GetAllContinuingAppoinments()
    {
        List<Appointment> continuing = Appointments.FindAll(a => DateTime.Now < a.EndDate);
        return continuing;
    }

}
