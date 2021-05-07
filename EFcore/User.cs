using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFcore
{
    public class User
    {
        public int Id { get; set; }
        [MaxLength(256)]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
        [NotMapped]
        public int FailedTry { get; set; }
    }
}
