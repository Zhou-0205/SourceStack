using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPage.Pages.Register
{
    public class MessageModel : PageModel
    {
        public IActionResult OnGet()
        {
            ViewData["HasLogon"] = Request.Cookies[Keys.UserName];
            if (string.IsNullOrEmpty(Request.Cookies[Keys.UserName]))
            {
                return RedirectToPage("LogOn");
            }
            return Page();
        }
    }
}
