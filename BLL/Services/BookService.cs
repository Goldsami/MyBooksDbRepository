using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BLL.DTOs;
using BLL.Interfaces;

namespace BLL.Services
{
    public class BookService : IBookService
    {
        public Task<OperationDetails> CreateBookAsync(BookDTO book)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> DeleteBookAsync(int bookId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookDTO> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public BookDTO GetBook(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> UpdateBookAsync(BookDTO book)
        {
            throw new NotImplementedException();
        }
    }
}
