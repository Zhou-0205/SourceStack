using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CsharpLearn
{
    [Index("Createtime", IsUnique = true)]
    [Table("Register")]
    class Student : Entity
    {
        [Key]
        [Column("UserName")]
        [MaxLength(256)]
        public string Name { get; set; }

        [Required]
        public string  Password { get; set; }
        public int Age { get; set; }

        [NotMapped]
        public int FailedTry { get; set; }
        public DateTime Createtime { get; set; }
    }
}
