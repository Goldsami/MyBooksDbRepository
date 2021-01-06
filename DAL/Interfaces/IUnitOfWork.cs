using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    interface IUnitOfWork: IDisposable
    {
        IRepository<Genre> Genres { get; }
        IRepository<Book> Books { get; }
        IRepository<Author> Authors { get; }
        IRepository<User> Users { get; }
        IRepository<BooksList> BooksLists { get; }

        Task SaveAsync();
    }
}
