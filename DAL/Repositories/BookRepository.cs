using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities;
using DAL.Context;

namespace DAL.Repositories
{
    public class BookRepository : IRepository<Book>
    {
        private MyBooksDbContext _db;

        public BookRepository(MyBooksDbContext context)
        {
            _db = context;
        }

        public void Create(Book item)
        {
            try
            {
                _db.Books.Add(item);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Delete(int id)
        {
            try
            {
                var item = _db.Books.Find(id);
                _db.Books.Remove(item);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Book Get(int id)
        {
            try
            {
                return _db.Books.Find(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEnumerable<Book> GetAll()
        {
            try
            {
                return _db.Books;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Update(Book item)
        {
            try
            {

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
