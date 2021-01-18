using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _17BangMVC.Controllers
{
    public class PlanController : Controller
    {
        // GET: Plan
        public ActionResult New()
        {
            return View();
        }
    }
}