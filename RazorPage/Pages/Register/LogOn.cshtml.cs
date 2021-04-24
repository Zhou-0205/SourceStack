using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using E=RazorPage.Entities;
using RazorPage.Filter;
using RazorPage.Repositories;

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
        [Required(ErrorMessage = "�û�������Ϊ��")]
        public string Name { get; set; }
        [MinLength(4, ErrorMessage = "���벻��������λ")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public void OnGet()
        {
            ViewData["HasLogon"] = Request.Cookies[Keys.UserName];
            ViewData["UserId"] = Request.Cookies[Keys.UserId];
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
                ModelState.AddModelError(nameof(Name), "* �û���������");
                return Page();
            }
            if (user.Password != Password)
            {
                ModelState.AddModelError(nameof(Password), "* �û������������");
                return Page();
            }

            CookieOptions cookieOptions = new CookieOptions();
            if (RememberMe)
            {
                cookieOptions.Expires = DateTime.Now.AddDays(14);
            }//else expires=session

            Response.Cookies.Append(Keys.UserId, user.Id.ToString(), cookieOptions);
            Response.Cookies.Append(Keys.UserName, user.Name.ToString(), cookieOptions);

            string path = Request.Query["prepage"].ToString();
            if (!string.IsNullOrEmpty(path))
            {
                return Redirect(path);
            }
            return Redirect("/Article/Index");
        }
    }
}
