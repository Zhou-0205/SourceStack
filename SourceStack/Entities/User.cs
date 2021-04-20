using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SourceStack.Entities
{
    public class User : Entity
    {
        [Display(Name="用户名")]
        [Required(ErrorMessage ="用户名不能为空")]
        public string Name { get; set; }
        [MinLength(4,ErrorMessage ="密码不能少于四位")]
        public string Password { get; set; }     
        public User InvitedBy { get; set; }
        [StringLength(4,MinimumLength =4,ErrorMessage ="长度只能为4位")]
        public string InvitedCode { get; set; }
        public int BangMoney { get; set; }
    }
}
