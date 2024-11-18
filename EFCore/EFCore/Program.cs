using EFCore.Context;
using EFCore.Exceptions;
using EFCore.Models;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace EFCore;

internal class Program
{
    static void Main(string[] args)
    {
        using(AppDbContext context = new AppDbContext())
        {
            context.Products.AddRange(new List<Product> { new Product { Name = "Laptop", Price = 1500 },new Product{Name = "Phone", Price = 1200} });
            context.SaveChanges();
        }


            
            while (true)
            {
            Console.WriteLine("1. Register\r\n2. Login");
            Console.WriteLine("Seciminizi daxil edin: ");
            int code = int.Parse(Console.ReadLine());
                switch (code)
                {
                    case 1:
                        Register();
                        break;
                    case 2:
                        Login();
                        break;
                    default:
                        Console.WriteLine("Yanlis secim");
                        break;
                }


            }
        
    }
    static void Register()
    {
        Console.WriteLine("Adinizi daxil edin: ");
        string name = Console.ReadLine();

        Console.WriteLine("Soyadinizi daxil edin: ");
        string surname = Console.ReadLine();

        Console.WriteLine("Istifadeci adinizi daxil edin: ");
        string username = Console.ReadLine();
        

        Console.WriteLine("Sifrenizi daxil edin");
        string password = Console.ReadLine();

        using (AppDbContext context = new AppDbContext())
        {
            if(context.Users.Any(u => u.Username == username))
            {
                throw new UsernameAlreadyExist("Bu istifadeci adi movcuddur");
            }
            context.Users.Add(new User
            {
                Name = name,
                Surname = surname,
                Username = username,
                Password = password
            });
            context.SaveChanges();
            Console.WriteLine("Qeydiyyatdan ugurla kecdiniz!!");
        }
    }

    static void Login()
    {
        Console.WriteLine("Istifadeci adinizi daxil edin: ");
        string username = Console.ReadLine();

        Console.WriteLine("Sifrenizi daxil edin");
        string password = Console.ReadLine();

        using (AppDbContext context = new AppDbContext())
        {
            var user = context.Users.FirstOrDefault(x => x.Username == username && x.Password == password);
            if (user == null)
            {
                throw new UserNotFoundException("Istifadeci tapilmadi");
            }
            else
            {
                
                bool isContinue = true;
                while (isContinue)
                {
                    Console.WriteLine("1. Məhsullara bax.\r\n2. Səbətə bax.\r\n3. Hesabdan çıx.\r\n");
                    Console.WriteLine("Seciminizi daxil edin: ");
                    int code = int.Parse(Console.ReadLine());
                    switch (code)
                    {
                        case 1:
                            ViewProduct(user);
                            break;
                        case 2:
                            ViewBasket(user);
                            break;
                        case 3:
                            Console.WriteLine("Hesabdan cixdiniz.Yeniden daxil olun: ");
                            isContinue = false;
                            break;
                        default:
                            Console.WriteLine("Yanlis secim");
                         
                            break;



                    }

                }
            }
        }
    }

    static void ViewProduct(User user)
    {
        
        using (AppDbContext context = new AppDbContext())
        {
            List<Product> products = context.Products.ToList();
            
            Console.WriteLine("Movcud Mehsullar: ");
        foreach (var product in products)
        {
            Console.WriteLine($"{product.Id}.{product.Name}-{product.Price}");
        }
        Console.WriteLine("Mehsul elave etmek ucun id daxil edin: ");
            Console.WriteLine("0-Geri");
        int productId = int.Parse(Console.ReadLine());
            if (productId == 0)
            {
                return;
            }
            var newProduct = context.Products.FirstOrDefault(x => x.Id == productId);
            if (newProduct == null)
            {
                throw new ProductNotFoundException("Mehsul tapilmadi");
            }
            else
            {
                context.Baskets.Add(new Basket
                {
                    ProductId = newProduct.Id,
                    UserId = user.Id
                });
                context.SaveChanges();
                Console.WriteLine("Mehsul sebete elave olundu");
            }
        }
    }
    static void ViewBasket(User user)
    {
        using (AppDbContext context = new AppDbContext())
        {
            List<Basket> baskets = context.Baskets.Where(b => b.UserId == user.Id).ToList();
            
        Console.WriteLine("Sebetdeki mehsullariniz: ");
        foreach (var basket in baskets)
        {
                var product = context.Products.FirstOrDefault(x => x.Id == basket.ProductId);
                Console.WriteLine($"{product.Id}. {product.Name} - {product.Price}");
        }
        Console.WriteLine("Silmek ucun id daxil edin: ");
            int productId = int.Parse(Console.ReadLine());
            var basketItem = baskets.FirstOrDefault(x => x.ProductId == productId);
            if (basketItem == null)
            {
                throw new ProductNotFoundException("Mehsul tapilmadi");
            }
            else
            {

                context.Baskets.Remove(basketItem);
                context.SaveChanges();
                Console.WriteLine("Mehsul sebetden silindi");
            }
        }
    }
}
//Users:
//Id, Name, Surname, Username, Password

//Products:
//Id, Name, Price

//Baskets:
//Id, UserId, ProductId

//Users, Basket və Products deyə cədvəllərimiz var.
//Console açıldıqda
//1. Register
//2. Login
//deyə 2 menyu çıxacaq qarşımıza. Adam ya qeydiyyatdan keçəcək ya da login olmağa çalışacaq.
//Əgər login zamanı istifadəçi adı və ya parolu yalnış yazılmışdırsa. UserNotFoundException throwlasın.
//İstifadəçi düzgün login olduqdan sonra aşağıdakı menyu açılmalıdır.
//1. Məhsullara bax.
//2. Səbətə bax.
//3. Hesabdan çıx.

//1 - daxil olunan zaman bütün məhsullar "Id. Name - Price" şəklində düzülsün və istifadəçidən Consoledan ədəd (Id) qəbul etsin.
//Daxil olunan id-li product bazamızda varsa o zaman onu səbətə əlavə etsin.
//Məhsul tapılmadıqda isə ProductNotFoundException throwlasın.
//İstifadəçi 0 daxil edən zaman əvvəlki menyu görsənsin.
//2 - daxil olunan zaman istifadəçinin səbətə əlavə etdiyi məhsullar görsənsin.
//Eyni qaydada məhsullar "Id. Name - Price" şəklində düzülsün və istifadəçidən Consoledan ədəd (Id) qəbul etsin.
//İstifadəçinin daxil etdiyi id-li elementi Basketdən silsin. Həmin id-li element tapılmasa ProductNotFoundException throwlasın.
//3 - daxil olunan zaman login menyusu gəlsin.