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
        Task CreateGenreAsync(GenreDTO genre);
        Task UpdateGenreAsync(GenreDTO genre);
        Task DeleteGenreAsync(int genreId);
    }
}
