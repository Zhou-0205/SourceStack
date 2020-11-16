﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SELFstudy
{
    //注册/登录功能，定义一个User类，
    //包含字段：Name（用户名）、Password（密码）和 邀请人（InvitedBy）
    //方法：Register()、Login()
    //让User类无法被继承
    public sealed class User:Entity
    {
        //如果user.Name为“admin”，输入时修改为“系统管理员”
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set
            {
                if (_Name == "admin")
                {
                    _Name = "系统管理员";
                }
            }
        }
        //user.Password在类的外部只能改不能读
        private string _Password;
        public string Password
        {
            set { _Password = value; }
        }
        private User Invitedby;

        //每一个User对象一定有Name和Password赋值
        public User(string Name, string Password)
        {
            _Name = Name;
            _Password = Password;
        }

        public static void Register()
        { }
        public static void Login()
        { }
    }
}
