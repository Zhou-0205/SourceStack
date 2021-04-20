using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using E = RazorPage.Entities;
using RazorPage.Repositories;

namespace RazorPage.Pages.Article
{
    public class SingleModel : PageModel
    {
        private SingleRepository singleRepository;
        public SingleModel()
        {
            singleRepository = new SingleRepository();
        }
        public E.Article Articles { get; set; }
        public E.Article Previous { get; set; }
        public E.Article Next { get; set; }
        public void OnGet()
        {
            int id = Convert.ToInt32(RouteData.Values["id"]);
            //int id = Convert.ToInt32(Request.Query["Id"][0]);
            Articles = singleRepository.Find(id);
            Previous = singleRepository.Find(id - 1);
            Next = singleRepository.Find(id + 1);
        }
    }
}
