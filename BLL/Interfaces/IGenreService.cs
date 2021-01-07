using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BLL.DTOs;

namespace BLL.Interfaces
{
    interface IGenreService
    {
        GenreDTO GetGenre(int id);
        IEnumerable<GenreDTO> GetAllGenres();
        Task<OperationDetails> CreateGenreAsync(GenreDTO genre);
        Task<OperationDetails> UpdateGenreAsync(GenreDTO genre);
        Task<OperationDetails> DeleteGenreAsync(int genreId);
    }
}
