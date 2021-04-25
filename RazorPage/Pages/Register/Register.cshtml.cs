using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using E=RazorPage.Entities;
using RazorPage.Repositories;
using Microsoft.AspNetCore.Http;

namespace RazorPage.Pages.Register
{
    [BindProperties]
    public class RegisterModel : PageModel
    {
        private UserRepository userRepository;
        public RegisterModel()
        {
            userRepository = new UserRepository();
        }
        public E.User NewUser { get; set; }
        public string ConfirmPassword { get; set; }

        public void OnGet()
        {
            //ViewData["HasLogon"] = Request.Cookies[Keys.UserName];
            //ViewData["UserId"] = Request.Cookies[Keys.UserId];
            ViewData["UserId"] = HttpContext.Session.GetString(Keys.UserId);
            ViewData["UserName"] = HttpContext.Session.GetString(Keys.UserName);
        }
        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            if (ConfirmPassword != NewUser.Password)
            {
                ModelState.AddModelError("ConfirmPassword", "两次输入密码不一致");
                return;
            }

            E.User invitedBy = userRepository.GetByName(NewUser.InvitedBy.Name);

            if (invitedBy == null)
            {
                ModelState.AddModelError("NewUser.InvitedBy.Name", "邀请人不存在");
                return;
            }
            if (invitedBy.InvitedCode != NewUser.InvitedBy.InvitedCode)
            {
                ModelState.AddModelError("NewUser.InvitedBy.InvitedCode", "邀请码错误");
                return;
            }

            NewUser.InvitedBy = invitedBy;
            NewUser.Register();
            userRepository.Save(NewUser);


        }
    }
}
