using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using E = RazorPage.Entities;
using RazorPage.Repositories;

namespace RazorPage.Pages.User
{
    public class UserInfoModel : PageModel
    {
        private UserRepository userRepository;
        public UserInfoModel()
        {
            userRepository = new UserRepository();
        }
        public E.User Users { get; set; }
        public IActionResult OnGet()
        {
            ViewData["HasLogon"] = Request.Cookies[Keys.UserName];
            ViewData["UserId"] = Request.Cookies[Keys.UserId];
            int id = Convert.ToInt32(RouteData.Values["id"]);
            Users = userRepository.Find(id);

            if (string.IsNullOrEmpty(Request.Cookies[Keys.UserId]))
            {
                return RedirectToPage("/Register/LogOn");
            }
            return Page();
        }
    }
}
