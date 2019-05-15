using DataBindingSample.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksLibrary.Services
{
    public class BooksService : IBooksService
    {
        private List<Book> _books = new List<Book>()
        {
            new Book { Title = "Professional C# 7", Publisher = "Wrox Press", Authors = new string[] { "Christian Nagel" } },
            new Book { Title = "Professional C# 6", Publisher = "Wrox Press", Authors = new string[] { "Christian Nagel" } },
            new Book { Title = "Enterprise Services", Publisher = "AWL", Authors = new string[] { "Christian Nagel" } },
        };

        public IEnumerable<Book> GetBooks() => _books;
    }
}
