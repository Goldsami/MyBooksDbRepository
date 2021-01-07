using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BLL.DTOs;
using BLL.Interfaces;

namespace BLL.Services
{
    public class BooksListService : IBooksListService
    {
        public Task<OperationDetails> CreateBooksListAsync(BooksListDTO booksList)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> DeleteBooksListAsync(int booksListId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BooksListDTO> GetAllBooksLists()
        {
            throw new NotImplementedException();
        }

        public BooksListDTO GetBooksList(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> UpdateBooksListAsync(BooksListDTO booksList)
        {
            throw new NotImplementedException();
        }
    }
}
