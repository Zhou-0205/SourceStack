using System;
using System.Collections.Generic;
using System.Text;

namespace NewCsharplearn
{
    public class User : Entity, ISendMessage, IChat
    {
        //设计一个适用的机制，能确保用户（User）的昵称（Name）不能含有admin、17bang、管理员等敏感词。

        //确保用户（User）的密码（Password）：
        //长度不低于6
        //必须由大小写英语单词、数字和特殊符号（~!@#$%^&*()_+）组成
        private string _name;
        private string _password;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Contains("admin") || value.Contains("17bang") || value.Contains("管理员"))
                {
                    Console.WriteLine("输入词有敏感信息");
                    return;
                }
                else
                {
                    _name = value;
                }
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                if (value.Length < 6)
                {
                    Console.WriteLine("密码不符合长度");
                    return;
                }//else
                if (!PasswordIsTrue(value))
                {
                    Console.WriteLine("密码必须由大小写英语单词、数字和特殊符号（~!@#$%^&*()_+）组成");
                    return;
                }//else
                _password = value;
            }
        }
        public User InvitedBy { get; set; }
        public int HelpMoney { get; set; }
        public int HelpPoint { get; set; }
        public TokenManager Tokens { get; set; }

        public void Register() { }
        public void Login() { }
        //一起帮还可以在好友间发私信，所有又有了IChat接口，其中也有一个Send()方法声明。
        //假设User类同时继承了ISendMessage和IChat，如何处理？
        void ISendMessage.send() { }
        void IChat.send() { }

        public bool PasswordCheck(string password, string check)
        {
            char[] temp = password.ToCharArray();
            for (int i = 0; i < temp.Length; i++)
            {
                if (check.Contains(temp[i]))
                {
                    return true;
                }//else
            }
            return false;
        }
        public bool PasswordIsTrue(string password)
        {
            return
                (PasswordCheck(password, "0123456789")
                && PasswordCheck(password, "abcdefghijklmnopqrstuvwxyz")
                && PasswordCheck(password, "ABCDEFGHIJKLMNOPQRSTUVWXYZ")
                && PasswordCheck(password, "~!@#$%^&*()_+"));
        }
    }
}
