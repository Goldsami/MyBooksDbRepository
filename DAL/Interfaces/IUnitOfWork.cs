using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        IRepository<Genre> Genres { get; }
        IRepository<Book> Books { get; }
        IRepository<Mark> Marks { get; }
        IRepository<Author> Authors { get; }
        IRepository<User> Users { get; }
        IRepository<BooksList> BooksLists { get; }

        Task SaveAsync();
    }
}
