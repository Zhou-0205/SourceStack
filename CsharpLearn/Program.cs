using System;
using System.Data.Common;
using System.Data.SqlClient;

namespace CsharpLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlDbContext context = new SqlDbContext();
            //Student student1 = new Student
            //{
            //    Name = "小张",
            //    Age = 20,
            //    Createtime = new DateTime(2020, 8, 8),
            //    FailedTry = 0,
            //    Password = "1234"
            //};
            //Student student2 = new Student
            //{
            //    Name = "小赵",
            //    Age = 21,
            //    Createtime = new DateTime(2020, 9, 9),
            //    FailedTry = 1,
            //    Password = "qwer"
            //};
            //Student student3 = new Student
            //{
            //    Name = "小李",
            //    Age = 22,
            //    Createtime = new DateTime(2020, 10, 10),
            //    FailedTry = 2,
            //    Password = "wasd"
            //};
            //context.students.AddRange(student1, student2, student3);
            //context.SaveChanges();

            ////通过主键找到其中一个User对象
            //Student s1 = context.Find<Student>(1);
            ////修改该User对象的Name属性，将其同步到数据库
            //s1.Name = "小薰";
            //context.SaveChanges();
            ////不加载User对象，仅凭其Id用一句Update SQL语句完成上题
            //Student s2 = new Student { Id = 1 };
            //context.Attach<Student>(s2);
            //s2.Name = "小薰";
            //context.SaveChanges();
            ////删除该用户
            //Student s3 = context.Find<Student>(1);
            //context.Remove(s3);
            //context.SaveChanges();

            User user = new User { Name = "zdh", Password = "123456" };
            Email email = new Email { Title = "注册", body = "邀请您注册", EmailAddress = "1234567@qq.com" };
            user.Send = email;
            email.Author = user;

            context.Add<User>(user);
            context.Add<Email>(email);
            context.SaveChanges();

            //var db = context.Database;
            //db.EnsureDeleted();
            //db.EnsureCreated();
        }
    }
}
