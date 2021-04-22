using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage.Entities;
using RazorPage.Repositories;

namespace RazorPage.Pages.Register
{
    [BindProperties]
    public class LogOnModel : PageModel
    {
        private UserRepository userRepository;
        public LogOnModel()
        {
            userRepository = new UserRepository();
        }
        [Required(ErrorMessage = "用户名不能为空")]
        public string Name { get; set; }
        [MinLength(4, ErrorMessage = "密码不能少于四位")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public void OnGet()
        {
            ViewData["HasLogon"] = Request.Cookies[Keys.UserId];
        }
        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }

            User user = userRepository.GetByName(Name);

            if (user == null)
            {
                ModelState.AddModelError(nameof(Name), "* 用户名不存在");
                return;
            }
            if (user.Password != Password)
            {
                ModelState.AddModelError(nameof(Password), "* 用户名或密码错误");
                return;
            }

            CookieOptions cookieOptions = new CookieOptions();
            if (RememberMe)
            {
                cookieOptions.Expires = DateTime.Now.AddDays(14);
            }//else expires=session

            Response.Cookies.Append(Keys.UserId, user.Id.ToString(), cookieOptions);
        }
    }
}
