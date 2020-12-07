using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SourceStack.Repository;
using E = SourceStack.Entities;

namespace SourceStack.Pages.Article
{
    public class IndexModel : PageModel
    {
        private ArticleRepository articleRepository;
        public IndexModel()
        {
            articleRepository = new ArticleRepository();
        }
        public IList<E.Article> Article { get; set; }
        public int PagesCount { get; set; }
        public int PageIndex { get; set; }

        const int pageSize = 7;
        public void OnGet()
        {
            PageIndex = Convert.ToInt32(Request.Query["pageIndex"][0]);
            PagesCount = articleRepository.ArticleCount() / pageSize;
            Article = articleRepository.Get(PageIndex, pageSize);
        }


    }
}
