using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpLearn
{
    public class Article : Content, IPraise
    {
        public string[] Keywords { get; set; }
        public int AgreeAmount { get; set; }
        public int DisAgreeAmount { get; set; }
        public override void Release()
        {
            Author.HelpCoin--;
            Console.WriteLine("消耗一个帮帮币");
        }
        public void AgreeBy(User voter)
        {
            voter.HelpPoint++;
            Author.HelpPoint++;
            AgreeAmount++;
        }
        public void DisAgreeBy(User voter)
        {
            voter.HelpPoint--;
            Author.HelpPoint--;
            DisAgreeAmount++;
        }
    }
}
