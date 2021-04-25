using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPage.Pages.Register
{
    public class LogOffModel : PageModel
    {
        public IActionResult OnGet()
        {
            //Response.Cookies.Delete(Keys.UserName);
            //Response.Cookies.Delete(Keys.UserId);

            HttpContext.Session.Remove(Keys.UserId);
            HttpContext.Session.Remove(Keys.UserName);

            //return RedirectToPage("LogOn");

            return Redirect(Request.Headers["referer"]);
        }
    }
}
