using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BLL.DTOs;

namespace BLL.Interfaces
{
    public interface IUserService : IBooksDbService<UserDTO>
    {
    }
}
