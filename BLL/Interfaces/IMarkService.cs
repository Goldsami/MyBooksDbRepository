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
        Task CreateMarkAsync(MarkDTO mark);
        Task UpdateMarkAsync(MarkDTO mark);
        Task DeleteMarkAsync(int markId);
    }
}
