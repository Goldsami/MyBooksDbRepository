using DAL.Context;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    class MarkRepository : IRepository<Mark>
    {
        private MyBooksDbContext _db;

        public MarkRepository(MyBooksDbContext context)
        {
            _db = context;
        }

        public void Create(Mark item)
        {
            try
            {
                _db.Marks.Add(item);
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
                var item = _db.Marks.Find(id);
                _db.Marks.Remove(item);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Mark Get(int id)
        {
            try
            {
                return _db.Marks.Find(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEnumerable<Mark> GetAll()
        {
            try
            {
                return _db.Marks;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Update(Mark item)
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
}
