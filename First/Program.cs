using System;
using System.Dynamic;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            string code = "xyz0", name = "小李", password = "123456";

            Console.WriteLine("请输入验证码");
            string usecode = Console.ReadLine();
            if (usecode == code)
            {
                Console.WriteLine("请输入用户名");
                string usename = Console.ReadLine();
                if (usename == name)
                {
                    Console.WriteLine("请输入密码");
                    string usepassword = Console.ReadLine();
                    if (usepassword == password)
                    {
                        Console.WriteLine("恭喜，登录成功");
                    }
                    else
                    {
                        Console.WriteLine("用户名或密码错误");
                    }
                }
                else
                {
                    Console.WriteLine("用户名不存在");
                }
            }
            else
            {
                Console.WriteLine("验证码错误");
            }
        }
    }
}
