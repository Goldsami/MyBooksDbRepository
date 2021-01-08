using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTOs;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using DAL.Repositories;

namespace BLL.Services
{
    public class UserService : IUserService
    {
        private IUnitOfWork _db;
        private readonly IMapper _mapper;

        public UserService()
        {
            _db = new UnitOfWork();
            _mapper = MappingConfiguration.ConfigureMapper().CreateMapper();
        }

        public UserService(IUnitOfWork uow)
        {
            _db = uow;
            _mapper = MappingConfiguration.ConfigureMapper().CreateMapper();
        }

        public async Task CreateAsync(UserDTO item)
        {
            if (item == null)
                throw new NullReferenceException("User cannot be null");

            var itemToCreate = _mapper.Map<UserDTO, User>(item);

            try
            {
                _db.Users.Create(itemToCreate);
                await _db.SaveAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task UpdateAsync(UserDTO item)
        {
            if (item == null)
                throw new NullReferenceException("User cannot be null");

            var itemToUpdate = _db.Users.Get(item.UserId);

            if (itemToUpdate == null)
                throw new NullReferenceException("User doesn't exist");

            try
            {
                _db.Users.Update(itemToUpdate);
                await _db.SaveAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task DeleteAsync(int itemId)
        {
            try
            {
                _db.Users.Delete(itemId);
                await _db.SaveAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEnumerable<UserDTO> GetAll()
        {
            try
            {
                var items = _db.Users.GetAll();
                return _mapper.Map<IEnumerable<User>, IEnumerable<UserDTO>>(items);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public UserDTO Get(int id)
        {
            try
            {
                var item = _db.Users.Get(id);
                return _mapper.Map<User, UserDTO>(item);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
