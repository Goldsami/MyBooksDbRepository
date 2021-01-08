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
    public class BooksListService : IBooksListService
    {
        private IUnitOfWork _db;
        private readonly IMapper _mapper;

        public BooksListService()
        {
            _db = new UnitOfWork();
            _mapper = MappingConfiguration.ConfigureMapper().CreateMapper();
        }

        public BooksListService(IUnitOfWork uow)
        {
            _db = uow;
            _mapper = MappingConfiguration.ConfigureMapper().CreateMapper();
        }

        public async Task CreateAsync(BooksListDTO item)
        {
            if (item == null)
                throw new NullReferenceException("BooksList cannot be null");

            var itemToCreate = _mapper.Map<BooksListDTO, BooksList>(item);

            try
            {
                _db.BooksLists.Create(itemToCreate);
                await _db.SaveAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task UpdateAsync(BooksListDTO item)
        {
            if (item == null)
                throw new NullReferenceException("BooksList cannot be null");

            var itemToUpdate = _db.BooksLists.Get(item.BooksListId);

            if (itemToUpdate == null)
                throw new NullReferenceException("BooksList doesn't exist");

            try
            {
                _db.BooksLists.Update(itemToUpdate);
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
                _db.BooksLists.Delete(itemId);
                await _db.SaveAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEnumerable<BooksListDTO> GetAll()
        {
            try
            {
                var items = _db.BooksLists.GetAll();
                return _mapper.Map<IEnumerable<BooksList>, IEnumerable<BooksListDTO>>(items);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public BooksListDTO Get(int id)
        {
            try
            {
                var item = _db.BooksLists.Get(id);
                return _mapper.Map<BooksList, BooksListDTO>(item);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
