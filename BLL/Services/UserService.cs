using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTOs;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;

namespace BLL.Services
{
    public class UserService : IUserService
    {
        private IUnitOfWork _db;
        private readonly IMapper _mapper;

        public UserService(IUnitOfWork uow)
        {
            _db = uow;
            _mapper = MappingConfiguration.ConfigureMapper().CreateMapper();
        }

        public async Task CreateUserAsync(UserDTO user)
        {
            if (user == null)
                throw new NullReferenceException("User cannot be null");

            var userToCreate = _mapper.Map<UserDTO, User>(user);

            try
            {
                _db.Users.Create(userToCreate);
                await _db.SaveAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task UpdateUserAsync(UserDTO user)
        {
            if (user == null)
                throw new NullReferenceException("User cannot be null");

            var userToUpdate = _db.Users.Get(user.UserId);

            if (userToUpdate == null)
                throw new NullReferenceException("User doesn't exist");

            try
            {
                _db.Users.Update(userToUpdate);
                await _db.SaveAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task DeleteUserAsync(int userId)
        {
            try
            {
                _db.Users.Delete(userId);
                await _db.SaveAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEnumerable<UserDTO> GetAllUsers()
        {
            try
            {
                var users = _db.Users.GetAll();
                return _mapper.Map<IEnumerable<User>, IEnumerable<UserDTO>>(users);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public UserDTO GetUser(int id)
        {
            try
            {
                var user = _db.Users.Get(id);
                return _mapper.Map<User, UserDTO>(user);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
