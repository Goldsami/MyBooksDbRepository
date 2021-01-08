using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Entities
{
    public class Book
    {
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string ImagePath { get; set; }

        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
        public virtual IEnumerable<Genre> Genres { get; set; }
        public virtual IEnumerable<Mark> Marks { get; set; }
    }
}
