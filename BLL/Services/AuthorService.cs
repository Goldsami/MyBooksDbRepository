using AutoMapper;
using BLL.DTOs;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AuthorService : IAuthorService
    {
        private IUnitOfWork _db;
        private readonly IMapper _mapper;

        public AuthorService()
        {
            _db = new UnitOfWork();
            _mapper = MappingConfiguration.ConfigureMapper().CreateMapper();
        }

        public AuthorService(IUnitOfWork uow)
        {
            _db = uow;
            _mapper = MappingConfiguration.ConfigureMapper().CreateMapper();
        }

        public async Task CreateAsync(AuthorDTO item)
        {
            if (item == null)
                throw new NullReferenceException("Author cannot be null");

            var itemToCreate = _mapper.Map<AuthorDTO, Author>(item);

            try
            {
                _db.Authors.Create(itemToCreate);
                await _db.SaveAsync();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public async Task UpdateAsync(AuthorDTO item)
        {
            if (item == null)
                throw new NullReferenceException("Author cannot be null");

            var itemToUpdate = _db.Authors.Get(item.AuthorId);

            if (itemToUpdate == null)
                throw new NullReferenceException("Author doesn't exist");

            try
            {
                _db.Authors.Update(itemToUpdate);
                await _db.SaveAsync();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public async Task DeleteAsync(int itemId)
        {
            try
            {
                _db.Authors.Delete(itemId);
                await _db.SaveAsync();
            }
            catch (Exception e) 
            {
                throw e;
            }
        }

        public IEnumerable<AuthorDTO> GetAll()
        {
            try
            {
                var items = _db.Authors.GetAll();
                return _mapper.Map<IEnumerable<Author>, IEnumerable<AuthorDTO>>(items);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public AuthorDTO Get(int id)
        {
            try
            {
                var item = _db.Authors.Get(id);
                return _mapper.Map<Author, AuthorDTO>(item);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
