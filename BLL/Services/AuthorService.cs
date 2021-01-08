using AutoMapper;
using BLL.DTOs;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
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

        public AuthorService(IUnitOfWork uow)
        {
            _db = uow;
            _mapper = MappingConfiguration.ConfigureMapper().CreateMapper();
        }

        public async Task CreateAuthorAsync(AuthorDTO author)
        {
            if (author == null)
                throw new NullReferenceException("Author cannot be null");

            var authorToCreate = _mapper.Map<AuthorDTO, Author>(author);

            try
            {
                _db.Authors.Create(authorToCreate);
                await _db.SaveAsync();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public async Task UpdateAuthorAsync(AuthorDTO author)
        {
            if (author == null)
                throw new NullReferenceException("Author cannot be null");

            var authorToUpdate = _db.Authors.Get(author.AuthorId);

            if (authorToUpdate == null)
                throw new NullReferenceException("Author doesn't exist");

            try
            {
                _db.Authors.Update(authorToUpdate);
                await _db.SaveAsync();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public async Task DeleteAuthorAsync(int authorId)
        {
            try
            {
                _db.Authors.Delete(authorId);
                await _db.SaveAsync();
            }
            catch (Exception e) 
            {
                throw e;
            }
        }

        public IEnumerable<AuthorDTO> GetAllAuthors()
        {
            try
            {
                var authors = _db.Authors.GetAll();
                return _mapper.Map<IEnumerable<Author>, IEnumerable<AuthorDTO>>(authors);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public AuthorDTO GetAuthor(int id)
        {
            try
            {
                var author = _db.Authors.Get(id);
                return _mapper.Map<Author, AuthorDTO>(author);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
