using System;

namespace NewCsharplearn
{
    class Program
    {
        static void Main(string[] args)
        {
            //User zdh = new User("周丁浩", "123456");
            //zdh.Register();
            //zdh.Login();

            //Problem first = new Problem();
            //first.Publish();

            //HelpMoney add = new HelpMoney();
            //add.Filtrate();

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
            ContentService service = new ContentService();

            Content content = new Article();
            service.Publish(content);

            content = new Problem();
            service.Publish(content);

            content = new Suggest();
            service.Publish(content);
        }
    }
}
