using System;
using System.Collections.Generic;
using System.Text;

namespace EF
{
    public class Keyword : Entity
    {
        public string Name { get; set; }
        public IList<Article> Articles { get; set; }
        public IList<Problem> Problems { get; set; }
    }
}
