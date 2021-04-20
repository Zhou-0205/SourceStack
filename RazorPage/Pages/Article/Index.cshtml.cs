using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using E=RazorPage.Entities;
using RazorPage.Repositories;

namespace RazorPage.Pages.Article
{
    public class IndexModel : PageModel
    {
        private ArticleRepository articleRepository;
        public IndexModel()
        {
            articleRepository = new ArticleRepository();
        }
        public IList<E.Article> Articles { get; set; } 
        public int PageIndex { get; set; }
        public int PageCount { get; set; }

        const int pageSize = 3;
        public void OnGet()
        {
            PageIndex = Convert.ToInt32(RouteData.Values["id"]);
            //PageIndex = Convert.ToInt32(Request.Query["pageIndex"][0]);
            PageCount =articleRepository.ArticleCount() / pageSize;
            Articles = articleRepository.Get(PageIndex,pageSize);
        }
    }
}
