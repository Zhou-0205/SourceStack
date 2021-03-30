using System;
using System.Reflection;

namespace NewCsharplearn
{
    class Program
    {
        static void Main(string[] args)
        {
            //User zdh = new User();
            //zdh.Register();
            //zdh.Login();

            //Problem first = new Problem();
            //first.Publish();

            //HelpMoney add = new HelpMoney();
            //HelpMoney.Filtrate();

            //实例化文章和意见建议，调用他们：
            //继承自父类的属性和方法
            //自己的属性和方法
            //Article article = new Article();
            //article.Author = zdh;
            //article.Publish();
            //Suggest suggest = new Suggest();
            //suggest.Publish();
            //Problem problem = new Problem();
            //problem.Publish();

            //多态
            //ContentService service = new ContentService();

            //Content content = new Article();
            //service.Publish(content);

            //content = new Problem();
            //service.Publish(content);

            //content = new Suggest();
            //service.Publish(content);

            //DateTimed调用
            //Console.WriteLine(GetDate(new DateTime(2020, 10, 10), 10, Kind.day));
            //Computingtime.GetWeeks(Computingtime.GetFirstMondy(2021));

            //位运算
            //User z = new User
            //{
            //    Tokens = new TokenManager()
            //};
            //z.Tokens.Add(Token.Admin);
            //z.Tokens.Remove(Token.Admin);
            //z.Tokens.Has(Token.Admin);

            //用反射获取Publish()上的特性实例，输出其中包含的信息
            //Article article = new Article();
            //Attribute attribute = HelpMoneyChangedAttribute.GetCustomAttribute(
            //    typeof(Article).GetMethod("Publish"),
            //    typeof(HelpMoneyChangedAttribute)
            //    );
            //Console.WriteLine(((HelpMoneyChangedAttribute)attribute).Amount);

            //AlterCreateTime(article, new DateTime(2021, 3, 30));
            //AlterPublishTime(article, DateTime.Now);

        }
        //修改Content的CreateTime和PublishTime
        public static void AlterCreateTime(Content content, DateTime datetime)
        {
            typeof(Content)
                .GetProperty(nameof(content.CreateTime), BindingFlags.NonPublic | BindingFlags.Instance)
                .SetValue(content, datetime);
        }
        public static void AlterPublishTime(Content content, DateTime datetime)
        {
            typeof(Content)
                .GetProperty(nameof(content.PublishTime), BindingFlags.NonPublic | BindingFlags.Instance)
                .SetValue(content, datetime);
        }
    }
}
