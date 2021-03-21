using System;

namespace NewCsharplearn
{
    class Program
    {
        static void Main(string[] args)
        {
            User zdh = new User("周丁浩", "123456");
            User.Register();
            User.Login();

            Problem first = new Problem("");
            Problem.Publish();

            HelpMoney add = new HelpMoney();
            HelpMoney.Filtrate();
        }
    }
}
