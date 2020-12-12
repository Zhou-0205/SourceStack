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
        [Required(ErrorMessage = "�û�������Ϊ��")]
        public string Name { get; set; }
        [MinLength(4, ErrorMessage = "���벻��������λ")]
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
                ModelState.AddModelError(nameof(Name), "�û���������");
                return;
            }
            if (user.Password != Password)
            {
                ModelState.AddModelError(nameof(Password), "�û������������");
                return;
            }

            Response.Cookies.Append("userId",user.Id.ToString());
        }
    }
}
