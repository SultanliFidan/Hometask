using HospitalClass.Models;

namespace HospitalClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1. Appointment yarat\r\n2. Appointment-i bitir\r\n3. Bütün appointment-lərə bax\r\n4. Bu həftəki appointment-lərə bax\r\n5. Bugünki appointment-lərə bax\r\n 6. Bitməmiş appointmentlərə bax\r\n7. Menudan çıx");
            Console.WriteLine("Seciminizi daxil edin: ");

            Hospital hospital = new Hospital();

            while (true)
            {
                Console.WriteLine("Seciminizi daxil edin: ");
                int choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.Write("No daxil edin: ");
                        int no = int.Parse(Console.ReadLine());
                        Console.Write("Patient daxil edin: ");
                        string patient = Console.ReadLine();
                        Console.Write("Doctor daxil edin: ");
                        string doctor = Console.ReadLine();
                        Console.Write("StartDate daxil edin : ");
                        DateTime startDate = DateTime.Parse(Console.ReadLine());
                        Console.Write("EndDate daxil edin : ");
                        DateTime endDate = DateTime.Parse(Console.ReadLine());
                        Appointment appointment = new Appointment(patient,doctor, startDate, endDate);
                        hospital.AddAppointment(appointment);
                        Console.WriteLine("Appointment yaradıldı.");
                        break;
                    case 2:
                        Console.Write("Bitirilməli appointment-in No-sunu daxil edin: ");
                        int endNo = int.Parse(Console.ReadLine());
                        hospital.EndAppointment(endNo);
                        break;
                     
                    case 3:
                        Console.WriteLine("Bütün appointment-lər:");

                        foreach (var appointmen in hospital.GetAllAppointments())
                        {
                            Console.WriteLine($"No: {appointmen.No}, Patient: {appointmen.Patient}, Doctor: {appointmen.Doctor}, StartDate: {appointmen.StartDate}, EndDate: {appointmen.EndDate}");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Bu həftəki appointment-lər:");
                        foreach (var appointmen in hospital.GetWeeklyAppointments())
                        {
                            Console.WriteLine($"No: {appointmen.No} , Patient:  {appointmen.Patient}, Doctor: {appointmen.Doctor}, StartDate: {appointmen.StartDate} , EndDate:  {appointmen.EndDate}");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Bugünki appointment-lər:");
                        foreach (var appointmen in hospital.GetTodaysAppointments())
                        {
                            Console.WriteLine($"No: {appointmen.No}, Patient: {appointmen.Patient}, Doctor: {appointmen.Doctor}, StartDate: {appointmen.StartDate}, EndDate: {appointmen.EndDate}");
                        }       
                        break;
                    case 6:
                        Console.WriteLine("Bitməmiş appointment-lər:");

                        foreach (var appointmen in hospital.GetAllContinuingAppoinments())
                        {
                            Console.WriteLine($"No: {appointmen.No}, Patient: {appointmen.Patient}, Doctor: {appointmen.Doctor}, StartDate: {appointmen.StartDate}, EndDate: {appointmen.EndDate}");
                        }
                        break;
                    case 7:
                        ;
                        Console.WriteLine("Çıxış edildi.");
                        break;

                    default:
                        Console.WriteLine("Yanlış seçim. Yenidən cəhd edin.");
                        break;
                }
            }
        }
    }
}
