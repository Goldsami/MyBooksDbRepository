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
    public class GenreService : IGenreService
    {
        private IUnitOfWork _db;
        private readonly IMapper _mapper;

        public GenreService(IUnitOfWork uow)
        {
            _db = uow;
            _mapper = MappingConfiguration.ConfigureMapper().CreateMapper();
        }

        public async Task CreateGenreAsync(GenreDTO genre)
        {
            if (genre == null)
                throw new NullReferenceException("Genre cannot be null");

            var genreToCreate = _mapper.Map<GenreDTO, Genre>(genre);

            try
            {
                _db.Genres.Create(genreToCreate);
                await _db.SaveAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task UpdateGenreAsync(GenreDTO genre)
        {
            if (genre == null)
                throw new NullReferenceException("Genre cannot be null");

            var genreToUpdate = _db.Genres.Get(genre.GenreId);

            if (genreToUpdate == null)
                throw new NullReferenceException("Genre doesn't exist");

            try
            {
                _db.Genres.Update(genreToUpdate);
                await _db.SaveAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task DeleteGenreAsync(int genreId)
        {
            try
            {
                _db.Genres.Delete(genreId);
                await _db.SaveAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEnumerable<GenreDTO> GetAllGenres()
        {
            try
            {
                var genres = _db.Genres.GetAll();
                return _mapper.Map<IEnumerable<Genre>, IEnumerable<GenreDTO>>(genres);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public GenreDTO GetGenre(int id)
        {
            try
            {
                var genre = _db.Genres.Get(id);
                return _mapper.Map<Genre, GenreDTO>(genre);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
