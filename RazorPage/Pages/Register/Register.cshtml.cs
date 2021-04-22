using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage.Entities;
using RazorPage.Repositories;

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
        public User NewUser { get; set; }
        public string ConfirmPassword { get; set; }

        public void OnGet()
        {
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

            User invitedBy = userRepository.GetByName(NewUser.InvitedBy.Name);

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
