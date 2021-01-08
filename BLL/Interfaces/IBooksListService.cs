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
        Task CreateBooksListAsync(BooksListDTO booksList);
        Task UpdateBooksListAsync(BooksListDTO booksList);
        Task DeleteBooksListAsync(int booksListId);
    }
}
