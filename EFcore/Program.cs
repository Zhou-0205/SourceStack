using System;
using System.Linq;

namespace EFcore
{
    class Program
    {
        static void Main(string[] args)
        {
            //var db = new SqlDbContext().Database;
            //db.EnsureDeleted();
            //db.EnsureCreated();


            //Email和User有一对一的关系，参照课堂演示，在数据库上建立User外键引用Email的映射
            SqlDbContext context = new SqlDbContext();
            User user = new User { Name = "zdh", Password = "123456" };
            Email email = new Email { Title = "注册", body = "邀请您注册", EmailAddress = "1234567@qq.com" };
            user.Send = email;
            email.Author = user;

            context.Add<User>(user);
            context.Add<Email>(email);
            //按继承映射：Article / Problem以及他们的父类Content
            Problem problem1 = new Problem { Title = "TPH", PublishTime = DateTime.Now, Author = user, Status = ProblemStatus.assinting };
            Problem problem2 = new Problem { Title = "TPT", PublishTime = new DateTime(2020, 12, 20), Author = user, Status = ProblemStatus.cancelled, Reward = 10 };

            context.AddRange(problem1, problem2);
            context.SaveChanges();
            ////利用EF，插入3个User对象
            //SqlDbContext context = new SqlDbContext();
            //User student1 = new User
            //{
            //    Name = "小张",
            //    Password = "1234",
            //    FailedTry = 0
            //};
            //User student2 = new User
            //{
            //    Name = "小赵",
            //    Password = "qwer",
            //    FailedTry = 1
            //};
            //User student3 = new User
            //{
            //    Name = "小李",
            //    Password = "wasd",
            //    FailedTry = 2,
            //};
            //context.Users.AddRange(student1, student2, student3);
            //context.SaveChanges();

            ////通过主键找到其中一个User对象
            //User s1 = context.Find<User>(1);
            ////修改该User对象的Name属性，将其同步到数据库
            //s1.Name = "小王";
            //context.SaveChanges();
            ////不加载User对象，仅凭其Id用一句Update SQL语句完成上题
            //User s2 = new User { Id = 1 };
            //context.Attach<User>(s2);
            //s2.Name = "小王";
            //context.SaveChanges();
            ////删除该用户
            //User s3 = context.Find<User>(1);
            //context.Remove(s3);
            //context.SaveChanges();
        }
    }
}
