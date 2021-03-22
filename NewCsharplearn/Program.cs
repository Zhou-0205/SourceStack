using System;

namespace NewCsharplearn
{
    class Program
    {
        static void Main(string[] args)
        {
            User zdh = new User("周丁浩", "123456");
            zdh.Register();
            zdh.Login();

            Problem first = new Problem("");
            first.Publish();

            HelpMoney add = new HelpMoney();
            add.Filtrate();
        }
    }
}
