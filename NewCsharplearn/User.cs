using System;
using System.Collections.Generic;
using System.Text;

namespace NewCsharplearn
{
    //注册/登录功能，定义一个User类，包含字段：Name（用户名）、Password（密码）
    //和 邀请人（InvitedBy），和方法：Register()、Login()
    public class User
    {
        private static string name;
        private static string password;
        private static User invitedBy;
        public static void Register() { }
        public static void Login() { }
    }
}
