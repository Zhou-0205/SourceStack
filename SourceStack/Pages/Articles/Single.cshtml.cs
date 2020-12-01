using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SourceStack.Entities;
using SourceStack.Repository;

namespace SourceStack.Articles
{
    public class SingleModel : PageModel
    {
        private SingleRepository singleRepository;
        public SingleModel()
        {
            singleRepository = new SingleRepository();
        }
        public Article Article { get; set; }
        public void OnGet()
        {
            Article = singleRepository.Find(1);
        }
    }
}
