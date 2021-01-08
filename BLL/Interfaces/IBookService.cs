using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BLL.DTOs;

namespace BLL.Interfaces
{
    interface IBookService
    {
        BookDTO GetBook(int id);
        IEnumerable<BookDTO> GetAllBooks();
        Task CreateBookAsync(BookDTO book);
        Task UpdateBookAsync(BookDTO book);
        Task DeleteBookAsync(int bookId);
    }
}
