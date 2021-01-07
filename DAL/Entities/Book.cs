using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public int AuthorId { get; set; }
        public string ImagePath { get; set; }

        public virtual Author Author { get; set; }
        public virtual IEnumerable<Genre> Genres { get; set; }
    }
}
