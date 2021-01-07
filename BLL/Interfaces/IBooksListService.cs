using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BLL.DTOs;

namespace BLL.Interfaces
{
    interface IBooksListService
    {
        BooksListDTO GetBooksList(int id);
        IEnumerable<BooksListDTO> GetAllBooksLists();
        Task<OperationDetails> CreateBooksListAsync(BooksListDTO booksList);
        Task<OperationDetails> UpdateBooksListAsync(BooksListDTO booksList);
        Task<OperationDetails> DeleteBooksListAsync(int booksListId);
    }
}
