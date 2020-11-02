using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
    //实例化文章和意见建议，调用他们：

    //继承自父类的属性和方法
    //自己的属性和方法
    public class Article : Content, IAppraise
    {
        public override void publish()
        {
            Console.WriteLine("消耗一个帮帮币");
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
