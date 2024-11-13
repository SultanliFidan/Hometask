using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMicroProject.Models;

 class Book
{
    private static int _id;
    public int Id { get; }
    public string Name { get; set; }
    public string AuthorName { get; set; }
    public decimal Price { get; set; }

    public Book()
    {
        Id = ++_id;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Author: {AuthorName}, Price: {Price}");
    }
}
