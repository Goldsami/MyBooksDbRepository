using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    interface IMarkService
    {
        MarkDTO GetMark(int id);
        IEnumerable<MarkDTO> GetAllMarks();
        Task<OperationDetails> CreateMarkAsync(MarkDTO mark);
        Task<OperationDetails> UpdateMarkAsync(MarkDTO mark);
        Task<OperationDetails> DeleteMarkAsync(int markId);
    }
}
