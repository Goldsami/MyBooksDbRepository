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
        Task CreateUserAsync(UserDTO user);
        Task UpdateUserAsync(UserDTO user);
        Task DeleteUserAsync(int userId);
    }
}
