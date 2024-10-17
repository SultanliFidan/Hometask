namespace Models
{
    public class Manager
    {
        protected Employee GetPromotion(Employee employee)
        {
            employee.Salary += 100;
            Console.WriteLine($"Yeni maas {employee.Salary}");
            return employee;
        }
    }

    public class Assistant : Manager
    {
        public void GetFeedBack(Employee employee)
        {
            if (employee.IsSuccessfull)
            {
                GetPromotion(employee);
            }
            else
            {
                Console.WriteLine("Ugursuzdur");
            }
        }
    }

    public class Employee
    {
        private string _name;
        private bool _isSuccessfull;
        private float _salary;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public bool IsSuccessfull
        {
            get
            {
                return _isSuccessfull;
            }
            set
            {
                _isSuccessfull = value;
            }
        }
        public float Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value >= 350)
                {
                    _salary = value;
                }

            }
        }


    }

}