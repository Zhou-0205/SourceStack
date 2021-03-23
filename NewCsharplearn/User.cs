using System;
using System.Collections.Generic;
using System.Text;

namespace NewCsharplearn
{
    //注册/登录功能，定义一个User类，包含字段：Name（用户名）、Password（密码）
    //和 邀请人（InvitedBy），和方法：Register()、Login()

    //让User类无法被继承 sealed
    public class User : Entity
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

        public void Register() { }
        public void Login() { }
    }
}
