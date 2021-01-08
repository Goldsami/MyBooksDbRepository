using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class BookDTO
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string ImagePath { get; set; }

        public AuthorDTO Author { get; set; }   
        public virtual IEnumerable<GenreDTO> Genres { get; set; }
        public virtual IEnumerable<MarkDTO> Marks { get; set; }
    }
}
