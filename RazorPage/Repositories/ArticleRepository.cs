using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RazorPage.Entities;

namespace RazorPage.Repositories
{
    public class ArticleRepository
    {
        private static IList<Article> articles;
        public ArticleRepository()
        {
            UserRepository userRepository = new UserRepository();
            articles = new List<Article>
            {
                new Article
                {
                    Id=1,
                    Title=@"1-高阶：泛型 / 集合 / Lambda / 异常 / IO / 多线程",
                    Body=@"泛型可以有泛型方法/类等，同C#可以有约束public class 
                    Student<T extends IMajor> extends Person {子类继承时：
                    public class OnlineStudent<T extends IMajor> extends 
                    Student<T > {协变/逆变通配符：？实现extends：协变（out）super：
                    逆变（in）Optional 类对应NullableOptional<Integer> age =",
                    PublishTime =DateTime.Now,
                    Keywords= new List<Keyword>
                    {
                        new Keyword{Name="Java"},
                        new Keyword{Name="C#"},
                        new Keyword{Name="对比"},
                        new Keyword{Name="高阶语法"}
                    },
                    Author=userRepository.Find(1),
                },
                new Article
                {
                    Id=2,
                    Title=@"2-高阶：泛型 / 集合 / Lambda / 异常 / IO / 多线程",
                    Body=@"泛型可以有泛型方法/类等，同C#可以有约束public class 
                    Student<T extends IMajor> extends Person {子类继承时：
                    public class OnlineStudent<T extends IMajor> extends 
                    Student<T > {协变/逆变通配符：？实现extends：协变（out）super：
                    逆变（in）Optional 类对应NullableOptional<Integer> age =",
                    PublishTime =DateTime.Now,
                    Keywords= new List<Keyword>
                    {
                        new Keyword{Name="Java"},
                        new Keyword{Name="C#"},
                        new Keyword{Name="对比"},
                        new Keyword{Name="高阶语法"}
                    },
                    Author=userRepository.Find(2),
                },
                new Article
                {
                    Id=3,
                    Title=@"3-高阶：泛型 / 集合 / Lambda / 异常 / IO / 多线程",
                    Body=@"泛型可以有泛型方法/类等，同C#可以有约束public class 
                    Student<T extends IMajor> extends Person {子类继承时：
                    public class OnlineStudent<T extends IMajor> extends 
                    Student<T > {协变/逆变通配符：？实现extends：协变（out）super：
                    逆变（in）Optional 类对应NullableOptional<Integer> age =",
                    PublishTime =DateTime.Now,
                    Keywords= new List<Keyword>
                    {
                        new Keyword{Name="Java"},
                        new Keyword{Name="C#"},
                        new Keyword{Name="对比"},
                        new Keyword{Name="高阶语法"}
                    },
                    Author=userRepository.Find(3),
                },
                new Article
                {
                    Id=4,
                    Title=@"4-高阶：泛型 / 集合 / Lambda / 异常 / IO / 多线程",
                    Body=@"泛型可以有泛型方法/类等，同C#可以有约束public class 
                    Student<T extends IMajor> extends Person {子类继承时：
                    public class OnlineStudent<T extends IMajor> extends 
                    Student<T > {协变/逆变通配符：？实现extends：协变（out）super：
                    逆变（in）Optional 类对应NullableOptional<Integer> age =",
                    PublishTime =DateTime.Now,
                    Keywords= new List<Keyword>
                    {
                        new Keyword{Name="Java"},
                        new Keyword{Name="C#"},
                        new Keyword{Name="对比"},
                        new Keyword{Name="高阶语法"}
                    },
                    Author=userRepository.Find(4),
                },
                new Article
                {
                    Id=5,
                    Title=@"5-高阶：泛型 / 集合 / Lambda / 异常 / IO / 多线程",
                    Body=@"泛型可以有泛型方法/类等，同C#可以有约束public class 
                    Student<T extends IMajor> extends Person {子类继承时：
                    public class OnlineStudent<T extends IMajor> extends 
                    Student<T > {协变/逆变通配符：？实现extends：协变（out）super：
                    逆变（in）Optional 类对应NullableOptional<Integer> age =",
                    PublishTime =DateTime.Now,
                    Keywords= new List<Keyword>
                    {
                        new Keyword{Name="Java"},
                        new Keyword{Name="C#"},
                        new Keyword{Name="对比"},
                        new Keyword{Name="高阶语法"}
                    },
                    Author=userRepository.Find(1),
                },
                new Article
                {
                    Id=6,
                    Title=@"6-高阶：泛型 / 集合 / Lambda / 异常 / IO / 多线程",
                    Body=@"泛型可以有泛型方法/类等，同C#可以有约束public class 
                    Student<T extends IMajor> extends Person {子类继承时：
                    public class OnlineStudent<T extends IMajor> extends 
                    Student<T > {协变/逆变通配符：？实现extends：协变（out）super：
                    逆变（in）Optional 类对应NullableOptional<Integer> age =",
                    PublishTime =DateTime.Now,
                    Keywords= new List<Keyword>
                    {
                        new Keyword{Name="Java"},
                        new Keyword{Name="C#"},
                        new Keyword{Name="对比"},
                        new Keyword{Name="高阶语法"}
                    },
                    Author=userRepository.Find(2),
                },
                new Article
                {
                    Id=7,
                    Title=@"7-高阶：泛型 / 集合 / Lambda / 异常 / IO / 多线程",
                    Body=@"泛型可以有泛型方法/类等，同C#可以有约束public class 
                    Student<T extends IMajor> extends Person {子类继承时：
                    public class OnlineStudent<T extends IMajor> extends 
                    Student<T > {协变/逆变通配符：？实现extends：协变（out）super：
                    逆变（in）Optional 类对应NullableOptional<Integer> age =",
                    PublishTime =DateTime.Now,
                    Keywords= new List<Keyword>
                    {
                        new Keyword{Name="Java"},
                        new Keyword{Name="C#"},
                        new Keyword{Name="对比"},
                        new Keyword{Name="高阶语法"}
                    },
                    Author=userRepository.Find(3),
                },
                new Article
                {
                    Id=8,
                    Title=@"8-高阶：泛型 / 集合 / Lambda / 异常 / IO / 多线程",
                    Body=@"泛型可以有泛型方法/类等，同C#可以有约束public class 
                    Student<T extends IMajor> extends Person {子类继承时：
                    public class OnlineStudent<T extends IMajor> extends 
                    Student<T > {协变/逆变通配符：？实现extends：协变（out）super：
                    逆变（in）Optional 类对应NullableOptional<Integer> age =",
                    PublishTime =DateTime.Now,
                    Keywords= new List<Keyword>
                    {
                        new Keyword{Name="Java"},
                        new Keyword{Name="C#"},
                        new Keyword{Name="对比"},
                        new Keyword{Name="高阶语法"}
                    },
                    Author=userRepository.Find(4),
                },
                new Article
                {
                    Id=9,
                    Title=@"9-高阶：泛型 / 集合 / Lambda / 异常 / IO / 多线程",
                    Body=@"泛型可以有泛型方法/类等，同C#可以有约束public class 
                    Student<T extends IMajor> extends Person {子类继承时：
                    public class OnlineStudent<T extends IMajor> extends 
                    Student<T > {协变/逆变通配符：？实现extends：协变（out）super：
                    逆变（in）Optional 类对应NullableOptional<Integer> age =",
                    PublishTime =DateTime.Now,
                    Keywords= new List<Keyword>
                    {
                        new Keyword{Name="Java"},
                        new Keyword{Name="C#"},
                        new Keyword{Name="对比"},
                        new Keyword{Name="高阶语法"}
                    },
                    Author=userRepository.Find(1),
                },
                new Article
                {
                    Id=10,
                    Title=@"10-高阶：泛型 / 集合 / Lambda / 异常 / IO / 多线程",
                    Body=@"泛型可以有泛型方法/类等，同C#可以有约束public class 
                    Student<T extends IMajor> extends Person {子类继承时：
                    public class OnlineStudent<T extends IMajor> extends 
                    Student<T > {协变/逆变通配符：？实现extends：协变（out）super：
                    逆变（in）Optional 类对应NullableOptional<Integer> age =",
                    PublishTime =DateTime.Now,
                    Keywords= new List<Keyword>
                    {
                        new Keyword{Name="Java"},
                        new Keyword{Name="C#"},
                        new Keyword{Name="对比"},
                        new Keyword{Name="高阶语法"}
                    },
                    Author=userRepository.Find(2),
                },
            };

        }
        public IList<Article> Get(int pageIndex, int pageSize)
        {
            return articles
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }
        internal int ArticleCount()
        {
            return articles.Count;
        }
    }
}
