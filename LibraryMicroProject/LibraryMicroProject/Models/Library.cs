using LibraryMicroProject.Exception;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMicroProject.Models;

class Library
{
    private int _id;
    public int Id { get; }
    public string Name { get; set; }
    public List<Book> Books = new();
    public string Path { get; }
    public Library()
    {
        Path = "C:\\Users\\User\\Desktop\\Hometask\\LibraryMicroProject\\LibraryMicroProject\\Files\\Database.json";
    }

    public void AddBook(Book book)
    {
        if (Books.Contains(book))
        {
            throw new CustomBookException("Book exists");
        }
        Books.Add(book);
        string newBooks = JsonConvert.SerializeObject(Books);
        using (StreamWriter sw = new StreamWriter(Path))
        {
            sw.WriteLine(newBooks);
        }

    }

    public Book GetBookById(int id)
    {
        StreamReader sr = new StreamReader(Path);
        string result = sr.ReadToEnd();
        Books = JsonConvert.DeserializeObject<List<Book>>(result);
        Book book = Books.Find(book => book.Id == id);
        if (book == null)
        {
            throw new CustomBookException("Book doesn't founded");
        }
        return book;
    }
    public void RemoveBook(int id)
    {
        Book book = Books.Find(book => book.Id == id);
        if (book == null)
        {
            throw new CustomBookException("Book doesn't founded");
        }

        StreamReader sr = new StreamReader(Path);
        string result = sr.ReadToEnd();
        Books = JsonConvert.DeserializeObject<List<Book>>(result);
        Books.Remove(book);
        string newBooks = JsonConvert.SerializeObject(Books);
        using (StreamWriter sw = new StreamWriter(Path))
        {
            sw.WriteLine(newBooks);
        }
    }

}
