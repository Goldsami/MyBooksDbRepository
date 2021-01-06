using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Entities
{
    public class User: Person
    {
        public int UserId { get; set; }

        [Required]
        public string NickName { get; set; }
    }
}
