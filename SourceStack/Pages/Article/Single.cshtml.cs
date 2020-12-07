using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using E = SourceStack.Entities;
using SourceStack.Repository;

namespace SourceStack.Article
{
    public class SingleModel : PageModel
    {
        private SingleRepository singleRepository;
        public SingleModel()
        {
            singleRepository = new SingleRepository();
        }
        public E.Article Article { get; set; }
        public E.Article Previous { get; set; }
        public E.Article Next { get; set; }
        public void OnGet()
        {
            int id = Convert.ToInt32(Request.Query["Id"][0]);
            Article = singleRepository.Find(id);
            Previous = singleRepository.Find(id - 1);
            Next = singleRepository.Find(id + 1);
        }
    }
}
