using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    interface IAuthorService
    {
        AuthorDTO GetAuthor(int id);
        IEnumerable<AuthorDTO> GetAllAuthors();
        Task<OperationDetails> CreateAuthorAsync(AuthorDTO author);
        Task<OperationDetails> UpdateAuthorAsync(AuthorDTO author);
        Task<OperationDetails> DeleteAuthorAsync(int authorId);
    }
}
