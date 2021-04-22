using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPage.Pages.Register
{
    public class LogOffModel : PageModel
    {
        public void OnGet()
        {
            Response.Cookies.Delete(Keys.UserId);
        }
    }
}
