using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Author: Person
    {
        public int AuthorId { get; set; }

        public virtual IEnumerable<Book> Books { get; set; }
    }
}
