using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPage.Entities
{
    public class Article : Entity
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public User Author { get; set; }
        public DateTime PublishTime { get; set; }
        public IList<Keyword> Keywords { get; set; }
    }
}
