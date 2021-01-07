using BLL.DTOs;
using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class MarkService : IMarkService
    {
        public Task<OperationDetails> CreateMarkAsync(MarkDTO mark)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> DeleteMarkAsync(int markId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MarkDTO> GetAllMarks()
        {
            throw new NotImplementedException();
        }

        public MarkDTO GetMark(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> UpdateMarkAsync(MarkDTO mark)
        {
            throw new NotImplementedException();
        }
    }
}
