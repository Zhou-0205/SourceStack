using System;
using System.Collections.Generic;
using System.Text;

namespace EF
{
    public class Comment
    {
        public User Author { get; set; }
        public string Body { get; set; }
        public ContentVariety Target { get; set; }
    }
}
