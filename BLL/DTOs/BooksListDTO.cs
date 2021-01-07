using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class BooksListDTO
    {
        public int BooksListId { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public virtual IEnumerable<int> BookIds { get; set; }
    }
}
