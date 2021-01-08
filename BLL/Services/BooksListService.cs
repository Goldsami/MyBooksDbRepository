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
    public class BooksListService : IBooksListService
    {
        private IUnitOfWork _db;
        private readonly IMapper _mapper;

        public BooksListService(IUnitOfWork uow)
        {
            _db = uow;
            _mapper = MappingConfiguration.ConfigureMapper().CreateMapper();
        }

        public async Task CreateBooksListAsync(BooksListDTO booksList)
        {
            if (booksList == null)
                throw new NullReferenceException("BooksList cannot be null");

            var booksListToCreate = _mapper.Map<BooksListDTO, BooksList>(booksList);

            try
            {
                _db.BooksLists.Create(booksListToCreate);
                await _db.SaveAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task UpdateBooksListAsync(BooksListDTO booksList)
        {
            if (booksList == null)
                throw new NullReferenceException("BooksList cannot be null");

            var booksListToUpdate = _db.BooksLists.Get(booksList.BooksListId);

            if (booksListToUpdate == null)
                throw new NullReferenceException("BooksList doesn't exist");

            try
            {
                _db.BooksLists.Update(booksListToUpdate);
                await _db.SaveAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task DeleteBooksListAsync(int booksListId)
        {
            try
            {
                _db.BooksLists.Delete(booksListId);
                await _db.SaveAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEnumerable<BooksListDTO> GetAllBooksLists()
        {
            try
            {
                var booksLists = _db.BooksLists.GetAll();
                return _mapper.Map<IEnumerable<BooksList>, IEnumerable<BooksListDTO>>(booksLists);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public BooksListDTO GetBooksList(int id)
        {
            try
            {
                var booksList = _db.BooksLists.Get(id);
                return _mapper.Map<BooksList, BooksListDTO>(booksList);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
