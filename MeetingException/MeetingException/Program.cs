namespace MeetingException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MeetingSchedule schedule = new MeetingSchedule();

            try
            {
                Console.WriteLine("İlk meeting: 1 Noyabr 2024 - 2 Noyabr 2024");
                schedule.SetMeeting("Fidan", new DateTime(2024, 11, 1), new DateTime(2024, 11, 2));

                Console.WriteLine("Meeting: 1 Noyabr 2024 - 3 Noyabr 2024");
                schedule.SetMeeting("Nigar", new DateTime(2024, 11, 1), new DateTime(2024, 11, 3));

            }
            catch (ReservedDateIntervalException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            catch (WrongDateIntervalException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

            try
            {
                Console.WriteLine("\nMeeting: 5 Noyabr 2024 - 3 Noyabr 2024");
                schedule.SetMeeting("Sumaya", new DateTime(2024, 11, 5), new DateTime(2024, 11, 3));

            }
            catch (ReservedDateIntervalException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            catch (WrongDateIntervalException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

            try
            {
                Console.WriteLine("\nMeeting: 3 Kasım 2024 - 4 Kasım 2024");
                schedule.SetMeeting("Necibe", new DateTime(2024, 11, 3), new DateTime(2024, 11, 4));

            }
            catch (ReservedDateIntervalException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            catch (WrongDateIntervalException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

            foreach (var meeting in schedule.Meetings)
            {
                Console.WriteLine($"- {meeting.FullName}: {meeting.FromDate} - {meeting.ToDate}");
            }
        }
    }
}
