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
    public class MarkService : IMarkService
    {
        private IUnitOfWork _db;
        private readonly IMapper _mapper;

        public MarkService(IUnitOfWork uow)
        {
            _db = uow;
            _mapper = MappingConfiguration.ConfigureMapper().CreateMapper();
        }

        public async Task CreateMarkAsync(MarkDTO mark)
        {
            if (mark == null)
                throw new NullReferenceException("Mark cannot be null");

            var markToCreate = _mapper.Map<MarkDTO, Mark>(mark);

            try
            {
                _db.Marks.Create(markToCreate);
                await _db.SaveAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task UpdateMarkAsync(MarkDTO mark)
        {
            if (mark == null)
                throw new NullReferenceException("Mark cannot be null");

            var markToUpdate = _db.Marks.Get(mark.MarkId);

            if (markToUpdate == null)
                throw new NullReferenceException("Mark doesn't exist");

            try
            {
                _db.Marks.Update(markToUpdate);
                await _db.SaveAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task DeleteMarkAsync(int markId)
        {
            try
            {
                _db.Marks.Delete(markId);
                await _db.SaveAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEnumerable<MarkDTO> GetAllMarks()
        {
            try
            {
                var marks = _db.Marks.GetAll();
                return _mapper.Map<IEnumerable<Mark>, IEnumerable<MarkDTO>>(marks);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public MarkDTO GetMark(int id)
        {
            try
            {
                var mark = _db.Marks.Get(id);
                return _mapper.Map<Mark, MarkDTO>(mark);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
