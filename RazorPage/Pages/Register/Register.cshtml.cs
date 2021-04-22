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
                ModelState.AddModelError("ConfirmPassword", "�����������벻һ��");
                return;
            }

            User invitedBy = userRepository.GetByName(NewUser.InvitedBy.Name);

            if (invitedBy == null)
            {
                ModelState.AddModelError("NewUser.InvitedBy.Name", "�����˲�����");
                return;
            }
            if (invitedBy.InvitedCode != NewUser.InvitedBy.InvitedCode)
            {
                ModelState.AddModelError("NewUser.InvitedBy.InvitedCode", "���������");
                return;
            }

            NewUser.InvitedBy = invitedBy;
            NewUser.Register();
            userRepository.Save(NewUser);
        }
    }
}
