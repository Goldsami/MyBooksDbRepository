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
        Task<OperationDetails> CreateBookAsync(BookDTO book);
        Task<OperationDetails> UpdateBookAsync(BookDTO book);
        Task<OperationDetails> DeleteBookAsync(int bookId);
    }
}
