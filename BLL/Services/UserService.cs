using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BLL.DTOs;
using BLL.Interfaces;

namespace BLL.Services
{
    public class UserService : IUserService
    {
        public Task<OperationDetails> CreateUserAsync(UserDTO user)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> DeleteUserAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDTO> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public UserDTO GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> UpdateUserAsync(UserDTO user)
        {
            throw new NotImplementedException();
        }
    }
}
