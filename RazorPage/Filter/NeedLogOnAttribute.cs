using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPage.Filter
{
    public class NeedLogOnAttribute : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            HttpContext httpContext = context.HttpContext;

            if (string.IsNullOrEmpty(httpContext.Session.GetString(Keys.UserId)))
            {
                string url = httpContext.Request.Path.Value;
                context.Result = new RedirectResult("/Register/LogOn?prepage="+url);
            }
        }
    }
}
