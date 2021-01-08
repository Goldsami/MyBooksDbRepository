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
        Task CreateAuthorAsync(AuthorDTO author);
        Task UpdateAuthorAsync(AuthorDTO author);
        Task DeleteAuthorAsync(int authorId);
    }
}
