using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpLearn
{
    //求助版块，定义一个类Problem，
    //包含字段：标题（Title）正文（Body）悬赏（Reward）发布时间（PublishDateTime）作者（Author）
    //方法Publish()
    public class Problem
    {
        private string _title;
        private string _body;
        private int _reword;
        private DateTime _publishTime;
        private User _author;
        public string Title { get; set; }
        public string Body { get; set; }
        //problem.Reward不能为负数
        public int Reword
        {
            get { return _reword; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("不能为负数");
                    return;
                }
            }
        }
        public DateTime PublishTime { get; set; }
        public User Author { get; set; }
        //一起帮的求助可以有多个（最多10个）关键字，请为其设置索引器，以便于我们通过其整数下标进行读写
        private string[] _keywords = new string[10];
        public string this[int index]
        {
            get { return _keywords[index]; }
            set { _keywords[index] = value; }
        }
        //每一个Problem对象一定有Body赋值
        public Problem(string Body)
        {
            _body = Body;
        }
    }
}
