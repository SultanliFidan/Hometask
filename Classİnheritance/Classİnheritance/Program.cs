using System.Runtime.CompilerServices;

namespace Classİnheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[]
            {
            new Product("Hp", "Brand1", 1200),
            new Product("Apple", "Brand3", 2000)
            };

            Product(products, 800, 2000);
        }

        static void Product(Product[] arr, double minPrice, double maxPrice)
        {

            foreach (Product product in arr)
            {
                if (product.Price >= minPrice && product.Price <= maxPrice)
                {
                    Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
                }
            }




        }

    }




    
}

