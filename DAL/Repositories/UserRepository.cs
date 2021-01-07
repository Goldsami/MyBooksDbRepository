using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interfaces;
using DAL.Entities;
using DAL.Context;

namespace DAL.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private MyBooksDbContext _db;

        public UserRepository(MyBooksDbContext context)
        {
            _db = context;
        }

        public void Create(User item)
        {
            try
            {
                _db.Users.Add(item);
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
                var item = _db.Users.Find(id);
                _db.Users.Remove(item);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public User Get(int id)
        {
            try
            {
                return _db.Users.Find(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEnumerable<User> GetAll()
        {
            try
            {
                return _db.Users;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Update(User item)
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
