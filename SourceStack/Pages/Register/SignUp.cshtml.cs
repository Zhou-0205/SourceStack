using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SourceStack.Entities;
using SourceStack.Repository;

namespace SourceStack.Pages.Register
{
    public class SignUpModel : PageModel
    {
        private UserRepository userRepository;
        public SignUpModel()
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
            userRepository.Save(NewUser);
            NewUser.BMAdd();
        }
    }
}
