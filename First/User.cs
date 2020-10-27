using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
    //观察“一起帮”的：
    //注册/登录功能，定义一个User类，包含字段：Name（用户名）、Password（密码）和 邀请人（InvitedBy），和方法：Register()、Login() 
    class User
    {
        private string _name;
        private User()
        {

        }
        public User(string name, string password)//每一个User对象一定有Name和Password赋值
        {
            _name = name;
            _password = password;
        }
        public string Name
        {
            set       //如果user.Name为“admin”，输入时修改为“系统管理员”
            {
                if (value == "admin")
                {
                    _name = "系统管理员";
                }
                else
                {
                    _name = value;
                }
            }
            get
            {
                return _name;
            }
        }
        private string _password;

        public string Password
        {
            set { _password = value; } //user.Password在类的外部只能改不能读
            //get { return _password; }
        }

        public User _invitedBy { get; set; }
        public string _inviteCode { get; set; }
        public string authCode { get; set; }
    }
    
}
