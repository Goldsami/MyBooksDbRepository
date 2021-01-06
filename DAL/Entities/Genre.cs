using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Entities
{
    public class Genre
    {
        public int GenreId { get; set; }

        [Required]
        public string Name { get; set; }

    }
}
