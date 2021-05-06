using System;
using System.Collections.Generic;
using System.Text;

namespace EF
{
    public class Article : Content
    {
        public IList<Keyword> KeyWords { get; set; }
    }
}
