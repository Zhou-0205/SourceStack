using System;
using System.Collections.Generic;
using System.Text;

namespace EFcore
{
    public class Article : Content
    {
        public IList<Keyword> KeyWords { get; set; }
    }
}
