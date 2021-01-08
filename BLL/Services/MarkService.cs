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
    public class MarkService : IMarkService
    {
        private IUnitOfWork _db;
        private readonly IMapper _mapper;

        public MarkService()
        {
            _db = new UnitOfWork();
            _mapper = MappingConfiguration.ConfigureMapper().CreateMapper();
        }

        public MarkService(IUnitOfWork uow)
        {
            _db = uow;
            _mapper = MappingConfiguration.ConfigureMapper().CreateMapper();
        }

        public async Task CreateAsync(MarkDTO item)
        {
            if (item == null)
                throw new NullReferenceException("Mark cannot be null");

            var itemToCreate = _mapper.Map<MarkDTO, Mark>(item);

            try
            {
                _db.Marks.Create(itemToCreate);
                await _db.SaveAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task UpdateAsync(MarkDTO item)
        {
            if (item == null)
                throw new NullReferenceException("Mark cannot be null");

            var itemToUpdate = _db.Marks.Get(item.MarkId);

            if (itemToUpdate == null)
                throw new NullReferenceException("Mark doesn't exist");

            try
            {
                _db.Marks.Update(itemToUpdate);
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
                _db.Marks.Delete(itemId);
                await _db.SaveAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEnumerable<MarkDTO> GetAll()
        {
            try
            {
                var items = _db.Marks.GetAll();
                return _mapper.Map<IEnumerable<Mark>, IEnumerable<MarkDTO>>(items);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public MarkDTO Get(int id)
        {
            try
            {
                var item = _db.Marks.Get(id);
                return _mapper.Map<Mark, MarkDTO>(item);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
