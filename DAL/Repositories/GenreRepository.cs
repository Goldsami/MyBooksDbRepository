using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interfaces;
using DAL.Entities;
using DAL.Context;

namespace DAL.Repositories
{
    public class GenreRepository : IRepository<Genre>
    {
        private MyBooksDbContext _db;

        public GenreRepository(MyBooksDbContext context)
        {
            _db = context;
        }

        public void Create(Genre item)
        {
            try
            {
                _db.Genres.Add(item);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public void Delete(int id)
        {
            try
            {
                var item = _db.Genres.Find(id);
                _db.Genres.Remove(item);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Genre Get(int id)
        {
            try
            {
                return _db.Genres.Find(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEnumerable<Genre> GetAll()
        {
            try
            {
                return _db.Genres;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Update(Genre item)
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
