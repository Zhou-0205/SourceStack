using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpLearn
{
    //注册/登录功能，定义一个User类，
    //包含字段：Name（用户名）、Password（密码）和 邀请人（InvitedBy）
    //方法：Register()、Login()
    //让User类无法被继承
    public sealed class User : Entity
    {
        private string _name;
        //private string _password;
        //private User _invitedby;
        public string Password { private get; set; }
        public User Invitedby { get; set; }
        public int HelpCoin { get; set; }
        public int HelpPoint { get; set; }
        public int HelpBean { get; set; }
        //如果user.Name为“admin”，输入时修改为“系统管理员”
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name == "admin")
                {
                    _name = "系统管理员";
                }
            }
        }
        //user.Password在类的外部只能改不能读


        //每一个User对象一定有Name和Password赋值
        //public User(string Name, string Password)
        //{
        //    _name = Name;
        //    _password = Password;
        //}
        public static void Register()
        { }
        public static void Login(string user)
        {
            Console.WriteLine($"恭喜用户{user}登陆成功");
        }
    }
}
