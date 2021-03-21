using System;
using System.Collections.Generic;
using System.Text;

namespace NewCsharplearn
{
    //求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、
    //悬赏（Reward）、发布时间（PublishDateTime）和作者（Author），和方法Publish()
    public class Problem
    {
        private static string title;
        private static string body;
        private static int reward;
        private static DateTime publishDateTime;
        private static User author;
        public static void Publish() { }
    }
}
