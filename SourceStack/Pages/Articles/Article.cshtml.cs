using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SourceStack.Repository;
using SourceStack.Entities;

namespace SourceStack.Pages.Articles
{
    public class ArticleModel : PageModel
    {
        private ArticleRepository articleRepository;
        public ArticleModel()
        {
            articleRepository = new ArticleRepository();
        }
        public IList<Article> Article { get; set; }
        public int PagesCount { get; set; }

        const int pageSize = 7;
        public void OnGet()
        {
            int pageIndex = Convert.ToInt32(Request.Query["pageIndex"][0]);

            PagesCount = articleRepository.ArticleCount() / pageSize;
            Article = articleRepository.Get(pageIndex,pageSize);
        }


    }
}
