using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities;
using DAL.Interfaces;
using DAL.Context;

namespace DAL.Repositories
{
    public class AuthorRepository : IRepository<Author>
    {
        private MyBooksDbContext _db;

        public AuthorRepository(MyBooksDbContext context)
        {
            _db = context;
        }

        public void Create(Author item)
        {
            try
            {
                _db.Authors.Add(item);
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
                var item = _db.Authors.Find(id);
                _db.Authors.Remove(item);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Author Get(int id)
        {
            try
            {
                return _db.Authors.Find(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEnumerable<Author> GetAll()
        {
            try
            {
                return _db.Authors;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Update(Author item)
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
