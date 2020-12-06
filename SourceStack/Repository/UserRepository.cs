using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SourceStack.Entities;

namespace SourceStack.Repository
{
    public class UserRepository
    {
        private static List<User> users;
        public UserRepository()
        {
            users = new List<User>
            {
                new User
                {
                    Id=1,
                    Name="小刘",
                },
                new User
                {
                    Id=2,
                    Name="小张",
                },
                new User
                {
                    Id=3,
                    Name="小李"
                },
                new User
                {
                    Id=4,
                    Name="小王"
                },
                new User
                {
                    Id=5,
                    Name="小赵"
                }
            };
        }
        public User Find(int id)
        {
            return users.Where(u => u.Id == id).SingleOrDefault();
        }
        public void Save(User user)
        {
            users.Add(user);
        }
    }
}
