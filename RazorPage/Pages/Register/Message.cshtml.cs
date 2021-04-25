using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage.Filter;

namespace RazorPage.Pages.Register
{
    [NeedLogOn]
    public class MessageModel : PageModel
    {
        public IActionResult OnGet()
        {
            //ViewData["HasLogon"] = Request.Cookies[Keys.UserName];
            //ViewData["UserId"] = Request.Cookies[Keys.UserId];
            ViewData["UserId"] = HttpContext.Session.GetString(Keys.UserId);
            ViewData["UserName"] = HttpContext.Session.GetString(Keys.UserName);
            //if (string.IsNullOrEmpty(Request.Cookies[Keys.UserName]))
            //{
            //    return RedirectToPage("LogOn");
            //}
            return Page();
        }
    }
}
