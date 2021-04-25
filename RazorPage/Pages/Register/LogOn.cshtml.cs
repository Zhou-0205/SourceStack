using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using E = RazorPage.Entities;
using RazorPage.Filter;
using RazorPage.Repositories;
using Newtonsoft.Json;

namespace RazorPage.Pages.Register
{
    [BindProperties]
    [ModelValidation]
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
        //public bool RememberMe { get; set; }
        public void OnGet()
        {
            //ViewData["HasLogon"] = Request.Cookies[Keys.UserName];
            //ViewData["UserId"] = Request.Cookies[Keys.UserId];
            ViewData["UserId"] = HttpContext.Session.GetString(Keys.UserId);
            ViewData["UserName"] = HttpContext.Session.GetString(Keys.UserName);
        }
        public IActionResult OnPost()
        {
            //if (!ModelState.IsValid)
            //{
            //    return;
            //}

            E.User user = userRepository.GetByName(Name);

            if (user == null)
            {
                ModelState.AddModelError(nameof(Name), "* 用户名不存在");
                return Page();
            }
            if (user.Password != Password)
            {
                ModelState.AddModelError(nameof(Password), "* 用户名或密码错误");
                return Page();
            }

            //CookieOptions cookieOptions = new CookieOptions();
            //if (RememberMe)
            //{
            //    cookieOptions.Expires = DateTime.Now.AddDays(14);
            //}//else expires=session

            HttpContext.Session.SetString(Keys.UserId, user.Id.ToString());
            HttpContext.Session.SetString(Keys.UserName, user.Name.ToString());

            //HttpContext.Session.SetString("User", JsonConvert.SerializeObject(LogOnModel));

            //Response.Cookies.Append(Keys.UserId, user.Id.ToString(), cookieOptions);
            //Response.Cookies.Append(Keys.UserName, user.Name.ToString(), cookieOptions);

            string path = Request.Query["prepage"].ToString();
            if (!string.IsNullOrEmpty(path))
            {
                return Redirect(path);
            }
            return Redirect("/Article/Index");
        }
    }
}
