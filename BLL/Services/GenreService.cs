using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BLL.DTOs;
using BLL.Interfaces;

namespace BLL.Services
{
    public class GenreService : IGenreService
    {
        public Task<OperationDetails> CreateGenreAsync(GenreDTO genre)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> DeleteGenreAsync(int genreId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GenreDTO> GetAllGenres()
        {
            throw new NotImplementedException();
        }

        public GenreDTO GetGenre(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> UpdateGenreAsync(GenreDTO genre)
        {
            throw new NotImplementedException();
        }
    }
}
