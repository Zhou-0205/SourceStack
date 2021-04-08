using System;
using System.Collections.Generic;
using System.Text;

namespace NewCsharplearn
{
    public class Article : Content, IPraise
    {
        //确保文章（Article）的标题不能为null值，也不能为一个或多个空字符组成的字符串
        //如果标题前后有空格，也予以删除
        private string _title;
        public override string Title 
        { 
            get { return _title; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("标题不能为空");
                    return;
                }
                else
                {
                    _title = value.Trim();
                }
            }
        }
        public IList<Keyword> KeyWords { get; set; }
        public IList<Comment<Article>> Comments { get; set; }
        public Appraise<Article> Appraise { get; set; }
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
