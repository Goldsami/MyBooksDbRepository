using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interfaces;
using DAL.Entities;
using DAL.Context;

namespace DAL.Repositories
{
    public class BooksListRepository : IRepository<BooksList>
    {
        private MyBooksDbContext _db;

        public BooksListRepository(MyBooksDbContext context)
        {
            _db = context;
        }

        public void Create(BooksList item)
        {
            try
            {
                _db.BooksLists.Add(item);
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
                var item = _db.BooksLists.Find(id);
                _db.BooksLists.Remove(item);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public BooksList Get(int id)
        {
            try
            {
                return _db.BooksLists.Find(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEnumerable<BooksList> GetAll()
        {
            try
            {
                return _db.BooksLists;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Update(BooksList item)
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
