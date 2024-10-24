namespace ListInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListInt listInt = new ListInt();

           
            listInt.Add(1);
            listInt.Add(2);
            listInt.Add(3);
            listInt.Add(4, 5, 6);

            
            Console.WriteLine(listInt);

        
            Console.WriteLine(listInt.Contains(3));

          
            Console.WriteLine(listInt.Pop());


            Console.WriteLine( listInt.IndexOf(4));

            Console.WriteLine(listInt.LastIndexOf(6));
            Console.WriteLine( listInt.Average());


            listInt.Insert(99, 2); 
            Console.WriteLine(listInt);

        }
    }
}
