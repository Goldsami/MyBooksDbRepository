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
    public class BookService : IBookService
    {
        private IUnitOfWork _db;
        private readonly IMapper _mapper;

        public BookService()
        {
            _db = new UnitOfWork();
            _mapper = MappingConfiguration.ConfigureMapper().CreateMapper();
        }

        public BookService(IUnitOfWork uow)
        {
            _db = uow;
            _mapper = MappingConfiguration.ConfigureMapper().CreateMapper();
        }

        public async Task CreateAsync(BookDTO item)
        {
            if (item == null)
                throw new NullReferenceException("Book cannot be null");

            var itemToCreate = _mapper.Map<BookDTO, Book>(item);

            try
            {
                _db.Books.Create(itemToCreate);
                await _db.SaveAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task UpdateAsync(BookDTO item)
        {
            if (item == null)
                throw new NullReferenceException("Book cannot be null");

            var itemToUpdate = _db.Books.Get(item.BookId);

            if (itemToUpdate == null)
                throw new NullReferenceException("Book doesn't exist");

            try
            {
                _db.Books.Update(itemToUpdate);
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
                _db.Books.Delete(itemId);
                await _db.SaveAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEnumerable<BookDTO> GetAll()
        {
            try
            {
                var items = _db.Books.GetAll();
                return _mapper.Map<IEnumerable<Book>, IEnumerable<BookDTO>>(items);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public BookDTO Get(int id)
        {
            try
            {
                var item = _db.Books.Get(id);
                return _mapper.Map<Book, BookDTO>(item);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
