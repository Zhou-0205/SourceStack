using System;

namespace EFcore
{
    class Program
    {
        static void Main(string[] args)
        {
            //利用EF，插入3个User对象
            SqlDbContext context = new SqlDbContext();
            User student1 = new User
            {
                Name = "小张",
                Password = "1234",
                FailedTry = 0
            };
            User student2 = new User
            {
                Name = "小赵",
                Password = "qwer",
                FailedTry = 1
            };
            User student3 = new User
            {
                Name = "小李",
                Password = "wasd",
                FailedTry = 2,
            };
            context.Users.AddRange(student1, student2, student3);
            context.SaveChanges();

            //通过主键找到其中一个User对象
            User s1 = context.Find<User>(1);
            //修改该User对象的Name属性，将其同步到数据库
            s1.Name = "小王";
            context.SaveChanges();
            //不加载User对象，仅凭其Id用一句Update SQL语句完成上题
            User s2 = new User { Id = 1 };
            context.Attach<User>(s2);
            s2.Name = "小王";
            context.SaveChanges();
            //删除该用户
            User s3 = context.Find<User>(1);
            context.Remove(s3);
            context.SaveChanges();
        }
    }
}
