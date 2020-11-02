using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
    class Suggest: Content,IAppraise
    {
        public override void publish()
        {
            Console.WriteLine("不消耗帮帮币");
        }
        public int AgreeAmount { get; set; }

        public int DisagreeAmount { get; set; }

        public void Agreedby(User voter)
        {
            voter.HelpPoint++;
            Author.HelpPoint++;
            AgreeAmount++;
        }
        public void Disagreedby(User voter)
        {
            voter.HelpPoint++;
            Author.HelpPoint++;
            DisagreeAmount++;
        }
        

    }
}
