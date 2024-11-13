using LibraryMicroProject.Models;
using Newtonsoft.Json;

namespace LibraryMicroProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Library library = new Library();
            Console.WriteLine("Menu\r\n1. Add book\r\n2. Get book by id\r\n3. Remove book\r\n0. Quit");
            Console.WriteLine("Seciminizi daxil edin: ");


            while (true)
            {
                int code = int.Parse(Console.ReadLine());
                switch (code)
                {
                    case 0:
                        Console.WriteLine("Quit");
                        break;
                    case 1:
                        Console.WriteLine("Add Book");
                        Book book = new Book();
                        Console.Write("Kitabin adi: ");
                        string name = Console.ReadLine();
                        Console.Write("Muellifin adi: ");
                        string authorName = Console.ReadLine();
                        Console.Write("Kitabin qiymeti: ");
                        decimal price = decimal.Parse(Console.ReadLine());
                        library.AddBook(book);
                        break;
                     case 2:
                        Console.WriteLine("Get book by id");
                        int id = int.Parse(Console.ReadLine());
                        library.GetBookById(id);
                        break ;
                      case 3:

                        Console.WriteLine("Remove book");
                        int id1 = int.Parse(Console.ReadLine());
                        library.RemoveBook(id1);
                        break;

                    default:
                        Console.WriteLine("Yanlis secim");
                        Console.WriteLine("Menu\r\n1. Add book\r\n2. Get book by id\r\n3. Remove book\r\n0. Quit");
                        break;


                }
            }

        }
    }
}
