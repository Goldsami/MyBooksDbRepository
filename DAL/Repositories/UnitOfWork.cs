using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interfaces;
using DAL.Entities;
using System.Threading.Tasks;
using DAL.Context;

namespace DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private MyBooksDbContext _db;
        private GenreRepository _genreRepository;
        private BookRepository _bookRepository;
        private MarkRepository _markRepository;
        private AuthorRepository _authorRepository;
        private UserRepository _userRepository;
        private BooksListRepository _listRepository;

        public UnitOfWork()
        {
            _db = new MyBooksDbContext();
        }

        public UnitOfWork(MyBooksDbContext context)
        {
            _db = context;
        }

        public IRepository<Genre> Genres
        {
            get
            {
                if(_genreRepository == null)
                {
                    _genreRepository = new GenreRepository(_db);
                }
                return _genreRepository;
            }
        }

        public IRepository<Book> Books
        {
            get
            {
                if (_bookRepository == null)
                {
                    _bookRepository = new BookRepository(_db);
                }
                return _bookRepository;
            }
        }

        public IRepository<Mark> Marks
        {
            get
            {
                if (_markRepository == null)
                {
                    _markRepository = new MarkRepository(_db);
                }
                return _markRepository;
            }
        }

        public IRepository<Author> Authors
        {
            get
            {
                if (_authorRepository == null)
                {
                    _authorRepository = new AuthorRepository(_db);
                }
                return _authorRepository;
            }
        }

        public IRepository<User> Users
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(_db);
                }
                return _userRepository;
            }
        }

        public IRepository<BooksList> BooksLists
        {
            get
            {
                if (_listRepository == null)
                {
                    _listRepository = new BooksListRepository(_db);
                }
                return _listRepository;
            }
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }

        private bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
            }
            this.disposed = true;
        }
    }
}
