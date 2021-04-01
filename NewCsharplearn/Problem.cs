using System;
using System.Collections.Generic;
using System.Text;

namespace NewCsharplearn
{
    //求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、
    //悬赏（Reward）、发布时间（PublishDateTime）和作者（Author），和方法Publish()
    public class Problem : Content, IPraise
    {
        //将之前的字段封装成属性，其中：
        //problem.Reward不能为负数
        //一起帮的求助可以有多个（最多10个）关键字，请为其设置索引器，
        //以便于我们通过其整数下标进行读写
        //每一个Problem对象一定有Body赋值
        //public Problem(string body)
        //{
        //    this.body = body;
        //}

        //private string title;
        //private string body;
        private int reward;
        //private DateTime publishDateTime;
        //private User author;
        private string[] keywords = new string[10];

        //public string TItle { get; set; }
        //public string Body { get; set; }
        public int Reward
        {
            get { return reward; }
            set
            {
                if (reward < 0)
                {
                    return;
                }
                else
                {
                    reward = value;
                }
            }
        }
        //public DateTime PublishDateTime { get; set; }
        //public User Author { get; set; }
        public string this[int index]
        {
            get { return keywords[index - 1]; }
            set { keywords[index - 1] = value; }
        }
        //考虑求助（Problem）的以下方法/属性，哪些适合实例，哪些适合静态，然后添加到类中：

        //Publish()：发布一篇求助，并将其保存到数据库
        //Load(int id)：根据Id从数据库获取一条求助
        //Delete(int id)：根据Id删除某个求助
        //repoistory：可用于在底层实现上述方法和数据库的连接操作等
        public Repoistory Repoistory { get; set; }
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
        public static void Load(int id) { }
        public static void Dalete(int id) { }

        public override void Publish()
        {
            Author.HelpMoney -= reward;
        }
    }
}
