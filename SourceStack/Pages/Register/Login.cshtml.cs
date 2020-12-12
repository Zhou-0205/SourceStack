using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SourceStack.Repository;
using SourceStack.Entities;
using System.ComponentModel.DataAnnotations;

namespace SourceStack.Pages.Register
{
    [BindProperties]
    public class LogInModel : PageModel
    {
        private UserRepository userRepository;
        public LogInModel()
        {
            userRepository = new UserRepository();
        }
        [Required(ErrorMessage = "用户名不能为空")]
        public string Name { get; set; }
        [MinLength(4, ErrorMessage = "密码不能少于四位")]
        public string Password { get; set; }
        public void OnGet()
        {

        }
        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }

            User user = userRepository.LogOn(Name);

            if (user.Name == null)
            {
                ModelState.AddModelError(nameof(Name), "用户名不存在");
                return;
            }
            if (user.Password != Password)
            {
                ModelState.AddModelError(nameof(Password), "用户名或密码错误");
                return;
            }

            Response.Cookies.Append("userId",user.Id.ToString());
        }
    }
}
