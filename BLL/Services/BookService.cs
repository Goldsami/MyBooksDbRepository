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
    public class BookService : IBookService
    {
        private IUnitOfWork _db;
        private readonly IMapper _mapper;

        public BookService(IUnitOfWork uow)
        {
            _db = uow;
            _mapper = MappingConfiguration.ConfigureMapper().CreateMapper();
        }

        public async Task CreateBookAsync(BookDTO book)
        {
            if (book == null)
                throw new NullReferenceException("Book cannot be null");

            var bookToCreate = _mapper.Map<BookDTO, Book>(book);

            try
            {
                _db.Books.Create(bookToCreate);
                await _db.SaveAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task UpdateBookAsync(BookDTO book)
        {
            if (book == null)
                throw new NullReferenceException("Book cannot be null");

            var bookToUpdate = _db.Books.Get(book.BookId);

            if (bookToUpdate == null)
                throw new NullReferenceException("Book doesn't exist");

            try
            {
                _db.Books.Update(bookToUpdate);
                await _db.SaveAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task DeleteBookAsync(int bookId)
        {
            try
            {
                _db.Books.Delete(bookId);
                await _db.SaveAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEnumerable<BookDTO> GetAllBooks()
        {
            try
            {
                var books = _db.Books.GetAll();
                return _mapper.Map<IEnumerable<Book>, IEnumerable<BookDTO>>(books);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public BookDTO GetBook(int id)
        {
            try
            {
                var book = _db.Books.Get(id);
                return _mapper.Map<Book, BookDTO>(book);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
