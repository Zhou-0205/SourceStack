using System;
using System.Collections.Generic;
using System.Text;

namespace NewCsharplearn
{
    public class Article : Content, IPraise
    {
        public string KeyWords { get; set; }
        public int Agreeamount { get; set; }
        public int Disagreeamount { get; set; }
        public void Agree(User voter)
        {
            voter.HelpPoint++;
            Author.HelpPoint++;
            Agreeamount++;
        }
        public void Disagree(User voter)
        {
            voter.HelpPoint--;
            Author.HelpPoint--;
            Disagreeamount--;
        }
        [HelpMoneyChanged]
        public override void Publish()
        {
            Author.HelpMoney--;
        }
    }
}
