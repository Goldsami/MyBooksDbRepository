using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTOs;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using DAL.Repositories;

namespace BLL.Services
{
    public class GenreService : IGenreService
    {
        private IUnitOfWork _db;
        private readonly IMapper _mapper;

        public GenreService()
        {
            _db = new UnitOfWork();
            _mapper = MappingConfiguration.ConfigureMapper().CreateMapper();
        }

        public GenreService(IUnitOfWork uow)
        {
            _db = uow;
            _mapper = MappingConfiguration.ConfigureMapper().CreateMapper();
        }

        public async Task CreateAsync(GenreDTO item)
        {
            if (item == null)
                throw new NullReferenceException("Genre cannot be null");

            var itemToCreate = _mapper.Map<GenreDTO, Genre>(item);

            try
            {
                _db.Genres.Create(itemToCreate);
                await _db.SaveAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task UpdateAsync(GenreDTO item)
        {
            if (item == null)
                throw new NullReferenceException("Genre cannot be null");

            var itemToUpdate = _db.Genres.Get(item.GenreId);

            if (itemToUpdate == null)
                throw new NullReferenceException("Genre doesn't exist");

            try
            {
                _db.Genres.Update(itemToUpdate);
                await _db.SaveAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task DeleteAsync(int itemId)
        {
            try
            {
                _db.Genres.Delete(itemId);
                await _db.SaveAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEnumerable<GenreDTO> GetAll()
        {
            try
            {
                var items = _db.Genres.GetAll();
                return _mapper.Map<IEnumerable<Genre>, IEnumerable<GenreDTO>>(items);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public GenreDTO Get(int id)
        {
            try
            {
                var item = _db.Genres.Get(id);
                return _mapper.Map<Genre, GenreDTO>(item);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
