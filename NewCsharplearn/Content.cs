using System;
using System.Collections.Generic;
using System.Text;

namespace NewCsharplearn
{
    // 观察一起帮的求助（Problem）、文章（Article）和意见建议（Suggest），根据他们的特点，抽象出一个父类：内容（Content）

    //Content中有一个字段：kind，记录内容的种类（problem/article/suggest等），只能被子类使用
    //确保每个Content对象都有kind的非空值
    //Content中的createTime，不能被子类使用，但只读属性PublishTime使用它为外部提供内容的发布时间
    //其他方法和属性请自行考虑，尽量贴近一起帮的功能实现
    public class Content : Entity
    {
        //public Content(string kind)
        //{
        //    this.kind = kind;
        //}
        //protected string kind;
        private DateTime creatTime;
        public string Kind { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public User Author { get; set; }
        public string Comment { get; set; }
        public DateTime PublishTime { get { return creatTime; } }

        public void Publish() { }
    }
}
