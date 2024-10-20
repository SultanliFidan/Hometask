namespace AccessModifiers
{
    class Singer
    {
        private string _name;
        private string _surname;
        private int _age;


        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > 0 && value.Length <= 100)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Ad 100-d'n boyuk ola bilmez");
                }

            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if(value.Length > 0 && value.Length <= 100)
                {
                    _surname = value;
                }
                else
                {
                    Console.WriteLine("Soyad 100-den boyuk ola bilmez");
                }
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 0 && value <= 170)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Yas 170-den boyuk ola bilmez");
                }
            }
        }

    }
}
