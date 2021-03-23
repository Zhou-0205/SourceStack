using System;
using System.Collections.Generic;
using System.Text;

namespace NewCsharplearn
{
    public class Article : Content
    {
        public string KeyWords { get; set; }
        public override void Publish()
        {
            Author.HelpMoney--;
        }
    }
}
