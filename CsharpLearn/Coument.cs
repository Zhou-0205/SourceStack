using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpLearn
{
    public class Coument : IPraise
    {
        public User Author { get; set; }
        public string Body { get; set; }
        public int AgreeAmount { get; set; }
        public int DisAgreeAmount { get; set; }
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
