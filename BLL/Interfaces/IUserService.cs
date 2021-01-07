using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BLL.DTOs;

namespace BLL.Interfaces
{
    interface IUserService
    {
        UserDTO GetUser(int id);
        IEnumerable<UserDTO> GetAllUsers();
        Task<OperationDetails> CreateUserAsync(UserDTO user);
        Task<OperationDetails> UpdateUserAsync(UserDTO user);
        Task<OperationDetails> DeleteUserAsync(int userId);
    }
}
