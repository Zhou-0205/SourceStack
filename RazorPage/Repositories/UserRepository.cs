using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RazorPage.Entities;

namespace RazorPage.Repositories
{
    public class UserRepository
    {
        private static IList<User> users;
        public UserRepository()
        {
            users = new List<User>
            {
                new User{Id=1,Name="张三"},
                new User{Id=2,Name="李四"},
                new User{Id=3,Name="王五"},
                new User{Id=4,Name="赵六"},
            };
        }
        public User Find(int id)
        {
            return users.Where(a => a.Id == id).SingleOrDefault();
        }
    }
}
