using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpLearn
{
    public class Article : Content
    {
        public string[] Keyword { get; set; }
        public override void Release()
        {
            Author.HelpCoin--;
            Console.WriteLine("消耗一个帮帮币");
        }
    }
}
