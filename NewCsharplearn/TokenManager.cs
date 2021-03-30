using System;
using System.Collections.Generic;
using System.Text;

namespace NewCsharplearn
{
    // 声明一个令牌管理（TokenManager）类：

    //使用私有的Token枚举_tokens存储所具有的权限
    //暴露Add(Token)、Remove(Token)和Has(Token)方法，可以添加、删除和判断其有无某个权限

    public class TokenManager
    {
        private Token _tokens = 0;
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
