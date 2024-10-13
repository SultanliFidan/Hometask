using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sual 1
            double cevreninSahesi = Area(2);
            Console.WriteLine("Cevrenin sahesi: " + cevreninSahesi);
            //Sual 2

            double duzbucaqlininSahesi = Area(4, 5);
            Console.WriteLine("Duzbucaqlinin sahesi: " + duzbucaqlininSahesi);
            //Sual 3

            double paralelpipedinSahesi = Area(1,2,3);
            Console.WriteLine("Paralelpipedin Sahesi: " + paralelpipedinSahesi);

            //Sual 4
            double ucbucaginSahei = Area(2, 3, 4, 6);
            Console.WriteLine("Ucbucagin Sahesi: " + ucbucaginSahei);


            //Sual a
            double toplama = NewMethod(2, 3, '+');
            Console.WriteLine(toplama);

            double vurma = NewMethod(2, 3, '*');
            Console.WriteLine(vurma);

            double ferq = NewMethod(5, 1, '-');
            Console.WriteLine(ferq);

            double bolme = NewMethod(5, 1, '/');
            Console.WriteLine(bolme);

            //Sual b

            double quvvetiTap = MyMethod(3,3);
            Console.WriteLine(quvvetiTap);



            //Sual c
            string gelenAd = AdSoyad("Fidan");
            Console.WriteLine(gelenAd);

            string gelenAdSoyad = AdSoyad("Sultanli ", "Fidan");
            Console.WriteLine(gelenAdSoyad);

            string name = AdSoyad("Fidan", "Sultanli ", "Ramal");
            Console.WriteLine(name);

            
        }

        //Sual 1
        static double Area(int r)
        {
            double p = 3;
            double result = p * r * r; 
            return result;

        }

        //Sual 2
        static double Area(int a , int b)
        {
            double result = a * b;
            return result;
        }

        //Sual 3
        static double Area(int a, int b, int c)
        {
            double s = (a * b + a * c + b * c);
            double result = 2 * s;
            return result;
        }

        //Sual 4
        static double Area(int r, int a, int b, int c)
        {
            double p = (a + b + c) / 2.0f;
            double s = p * r;
            return s;
        }


        //Sual a
        static double NewMethod(double num1, double num2, char op)
        {
            double result = 0;

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        
                    }
                    else
                    {
                        Console.WriteLine("Sifira bolmek olmur");
                        
                    }
                    break;
            }
            return result;
        }

        //Sual b

        static double MyMethod(double num1, double num2 = 2)
        {
            double quvvet = 1;

            if(num2 > 0)
            {
                for (int i = 0; i < num2; i++)
                {
                    quvvet *= num1;
                }
             
            }
            else
            {
                for (int i = 0;i < -num2; i++)
                {
                    quvvet *= num1;
                }
                quvvet = 1 / quvvet;
            }
            return quvvet;
            
        }


        //Sual c
        static string AdSoyad(string ad)
        {
            return ad;
        }

        static string AdSoyad(string soyad, string ad)
        {
            return soyad + " " + ad;
        }

        static string AdSoyad(string ad, string soyad, string ataadi)
        {
            return ad[0] + "." +soyad + ataadi;
        }
    }
}
