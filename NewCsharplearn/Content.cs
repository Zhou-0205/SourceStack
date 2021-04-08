using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace NewCsharplearn
{
    // 观察一起帮的求助（Problem）、文章（Article）和意见建议（Suggest），根据他们的特点，抽象出一个父类：内容（Content）

    //Content中有一个字段：kind，记录内容的种类（problem/article/suggest等），只能被子类使用
    //确保每个Content对象都有kind的非空值
    //Content中的createTime，不能被子类使用，但只读属性PublishTime使用它为外部提供内容的发布时间
    //其他方法和属性请自行考虑，尽量贴近一起帮的功能实现

    //Content类，该将其抽象成抽象类还是接口
    public abstract class Content : Entity<int>
    {
        //CreateTime（创建时间）和PublishTime（发布时间）都是只读的属性，
        //想一想他们应该在哪里赋值比较好，并完成相应代码
        //public Content(DateTime publishtime,DateTime createtime)
        //{
        //    this.PublishTime = publishtime;
        //    this.CreateTime = createtime;
        //}

        public virtual string Title { get; set; }
        protected ContentVariety Kind { get; set; }
        public string Body { get; set; }
        public User Author { get; set; }
        public string Comment { get; set; }
        public DateTime PublishTime { get; private set; }
        public DateTime CreateTime { get; private set; }
        public virtual void Publish() { }

    }
    public enum ContentVariety
    {
        suggest = 0,
        problem = 1,
        article = 2
    }
}
