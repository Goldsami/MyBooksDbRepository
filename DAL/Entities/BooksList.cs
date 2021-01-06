using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Entities
{
    public class BooksList
    {
        public int BooksListId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual IEnumerable<Book> Books { get; set; }

    }
}
