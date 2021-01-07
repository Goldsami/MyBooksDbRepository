using BLL.DTOs;
using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AuthorService : IAuthorService
    {
        public Task<OperationDetails> CreateAuthorAsync(AuthorDTO author)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> DeleteAuthorAsync(int authorId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AuthorDTO> GetAllAuthors()
        {
            throw new NotImplementedException();
        }

        public AuthorDTO GetAuthor(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> UpdateAuthorAsync(AuthorDTO author)
        {
            throw new NotImplementedException();
        }
    }
}
