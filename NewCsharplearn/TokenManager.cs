using System;
using System.Collections.Generic;
using System.Text;

namespace NewCsharplearn
{
    public class TokenManager
    {
        private static Token _tokens = 0;
        public Token Token => _tokens;
        public void Add(Token token)
        {
            if (Has(token))
            {
                Console.WriteLine("该用户已具有当前权限，无法添加");
            }
            else
            {
                _tokens = _tokens | token;
            }

        }
        public void Remove(Token token)
        {
            if (Has(token))
            {
                _tokens = _tokens ^ token;
            }
            else
            {
                Console.WriteLine("该用户不具有当前权限，无法删除");
            }
        }
        public bool Has(Token token)
        {
            return (token == (_tokens & token));
        }
    }
    public enum Token
    {
        SuperAdmin = 1,
        Admin = 2,
        Blogger = 4,
        Newbie = 8,
        Registered = 16
    }
}
