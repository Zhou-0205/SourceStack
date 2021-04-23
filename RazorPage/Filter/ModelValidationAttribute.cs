using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPage.Filter
{
    public class ModelValidationAttribute : Attribute, IPageFilter
    {
        public void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {

        }

        public void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            HttpContext httpContext = context.HttpContext;
            if (httpContext.Request.Method == "post")
            {
                Dictionary<string, string> errors =
                    context.ModelState.Where(m => m.Value.Errors.Any())
                        .ToDictionary(
                            m => m.Key,
                            m => m.Value.Errors
                                .Select(s => s.ErrorMessage)
                                .FirstOrDefault(s => s != null));
                ((PageModel)context.HandlerInstance).TempData[Keys.ErrorInfo] = errors;
            }
            else if (httpContext.Request.Method == "get")
            {
                Dictionary<string, string> errors =
                    ((PageModel)context.HandlerInstance).TempData[Keys.ErrorInfo] as Dictionary<string, string>;
                if (errors != null)
                {
                    foreach (var item in errors)
                    {
                        context.ModelState.AddModelError(item.Key, item.Value);
                    }
                }
            }//else nothing
        }

        public void OnPageHandlerSelected(PageHandlerSelectedContext context)
        {

        }
    }
}
