using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpLearn
{
    public class Suggest : Content, IPraise
    {
        public int Reward { get; set; }
        public int AgreeAmount { get; set; }
        public int DisAgreeAmount { get; set; }
        public override void Release()
        {
            Console.WriteLine("不需要消耗帮帮币");
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
