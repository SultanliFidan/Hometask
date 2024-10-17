using Models;

namespace ModelsDll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "Fidan";
            employee.Salary = 1000;
            employee.IsSuccessfull = true;

            Assistant assistant = new Assistant();
            assistant.GetFeedBack(employee);
        }
    }
}
