using System.Collections.Generic;
using DataBindingSample.Models;

namespace BooksLibrary.Services
{
    public interface IBooksService
    {
        IEnumerable<Book> GetBooks();
    }
}