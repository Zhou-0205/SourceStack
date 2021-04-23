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
            ViewData["HasLogon"] = Request.Cookies[Keys.UserName];
            Dictionary<string, string> errors = TempData[Keys.ErrorInfo] as Dictionary<string, string>;
            if (errors != null)
            {
                foreach (var item in errors)
                {
                    ModelState.AddModelError(item.Key, item.Value);
                }
            }
        }
        public IActionResult OnPost()
        {
            //if (!ModelState.IsValid)
            //{
            //    return;
            //}

            User user = userRepository.GetByName(Name);

            if (user == null)
            {
                ModelState.AddModelError(nameof(Name), "* 用户名不存在");
                Dictionary<string, string> errors =
                    ModelState.Where(m => m.Value.Errors.Any())
                        .ToDictionary(
                            m => m.Key,
                            m => m.Value.Errors
                                .Select(s => s.ErrorMessage)
                                .FirstOrDefault(s => s != null));
                TempData[Keys.ErrorInfo] = errors;
                return RedirectToPage();
            }
            if (user.Password != Password)
            {
                ModelState.AddModelError(nameof(Password), "* 用户名或密码错误");
                Dictionary<string, string> errors =
                   ModelState.Where(m => m.Value.Errors.Any())
                       .ToDictionary(
                           m => m.Key,
                           m => m.Value.Errors
                               .Select(s => s.ErrorMessage)
                               .FirstOrDefault(s => s != null));
                TempData[Keys.ErrorInfo] = errors;
                return RedirectToPage();
            }

            CookieOptions cookieOptions = new CookieOptions();
            if (RememberMe)
            {
                cookieOptions.Expires = DateTime.Now.AddDays(14);
            }//else expires=session

            Response.Cookies.Append(Keys.UserName, user.Name.ToString(), cookieOptions);

            string path = Request.Query["prepage"].ToString();
            if (path!=null)
            {
                return Redirect(path);
            }
            return RedirectToPage();

        }
    }
}
