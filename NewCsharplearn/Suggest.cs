using System;
using System.Collections.Generic;
using System.Text;

namespace NewCsharplearn
{
    public class Suggest : Content, IPraise
    {
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
        public override void Publish()
        {

        }
    }
}
