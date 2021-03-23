using System;
using System.Collections.Generic;
using System.Text;

namespace NewCsharplearn
{
    //注册/登录功能，定义一个User类，包含字段：Name（用户名）、Password（密码）
    //和 邀请人（InvitedBy），和方法：Register()、Login()

    //让User类无法被继承 sealed
    public class User : Entity, ISendMessage, IChat
    {
        //将之前的字段封装成属性，其中：
        //user.Password在类的外部只能改不能读
        //如果user.Name为“admin”，输入时修改为“系统管理员”
        //每一个User对象一定有Name和Password赋值

        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
        }

        private string name;
        private string password;
        //private User invitedBy;

        public string Name
        {
            get { return name; }
            set
            {
                if (value == "admin")
                {
                    name = "系统管理员";
                }
                else
                {
                    name = value;
                };
            }
        }
        public string Password { private get; set; }
        public User InvitedBy { get; set; }
        public int HelpMoney { get; set; }
        public int HelpPoint { get; set; }

        public void Register() { }
        public void Login() { }
        //一起帮还可以在好友间发私信，所有又有了IChat接口，其中也有一个Send()方法声明。
        //假设User类同时继承了ISendMessage和IChat，如何处理？
        void ISendMessage.send() { }
        void IChat.send() { }
    }
}
