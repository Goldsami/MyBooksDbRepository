using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class MarkDTO
    {
        public int MarkId { get; set; }
        public int MarkValue { get; set; }
        public int BookId { get; set; }
        public UserDTO User { get; set; }
    }
}
