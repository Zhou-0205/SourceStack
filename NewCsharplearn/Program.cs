using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace NewCsharplearn
{
    class Program
    {
        static void Main(string[] args)
        {
            //User zdh = new User();
            //zdh.Register();
            //zdh.Login();

            //Problem first = new Problem();
            //first.Publish();

            //HelpMoney add = new HelpMoney();
            //HelpMoney.Filtrate();

            //实例化文章和意见建议，调用他们：
            //继承自父类的属性和方法
            //自己的属性和方法
            //Article article = new Article();
            //article.Author = zdh;
            //article.Publish();
            //Suggest suggest = new Suggest();
            //suggest.Publish();
            //Problem problem = new Problem();
            //problem.Publish();

            //多态
            //ContentService service = new ContentService();

            //Content content = new Article();
            //service.Publish(content);

            //content = new Problem();
            //service.Publish(content);

            //content = new Suggest();
            //service.Publish(content);

            //DateTimed调用
            //Console.WriteLine(GetDate(new DateTime(2020, 10, 10), 10, Kind.day));
            //Computingtime.GetWeeks(Computingtime.GetFirstMondy(2021));

            //位运算
            //User z = new User
            //{
            //    Tokens = new TokenManager()
            //};
            //z.Tokens.Add(Token.Admin);
            //z.Tokens.Remove(Token.Admin);
            //z.Tokens.Has(Token.Admin);

            //用反射获取Publish()上的特性实例，输出其中包含的信息
            //Article article = new Article();
            //Attribute attribute = HelpMoneyChangedAttribute.GetCustomAttribute(
            //    typeof(Article).GetMethod("Publish"),
            //    typeof(HelpMoneyChangedAttribute)
            //    );
            //Console.WriteLine(((HelpMoneyChangedAttribute)attribute).Amount);

            //AlterCreateTime(article, new DateTime(2021, 3, 30));
            //AlterPublishTime(article, DateTime.Now);

            //构造一个能装任何数据的数组，并完成数据的读写
            //object[] array = new object[10];

            //array[0] = 1;

            //array[1] = "字符";

            //array[2] = 2;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            //string a = "12121";
            //string b = "121";
            //Console.WriteLine(GetCount(a, b));
            //string[] array = { "a", "b", "c", "d" };
            //Console.WriteLine(MimicJoin("~", array));

            //User zdh = new User();
            //zdh.Name = "17bang";
            //zdh.Password = "12345";
            //Console.WriteLine(zdh.Name);
            //Console.WriteLine(zdh.Password);

            //Article article = new Article();
            //article.Title = "";
            //Console.WriteLine(article.Title);

            //int[] arr = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(GetMax<int>(arr));
            //Console.WriteLine(BinarySearch<int>(arr, 2));

            //DoubleLinked<string> node1, node2, node3, node4, node5;

            //node1 = new DoubleLinked<string>() { Value = 1 };
            //node2 = new DoubleLinked<string>() { Value = 2 };
            //node3 = new DoubleLinked<string>() { Value = 3 };
            //node4 = new DoubleLinked<string>() { Value = 4 };
            //node5 = new DoubleLinked<string>() { Value = 5 };

            //node1.Next = node2;
            //node2.Next = node3;
            //node3.Next = node4;
            //node4.Next = node5;
            //node5.Next = null;

            //node5.Previous = node4;
            //node4.Previous = node3;
            //node3.Previous = node2;
            //node2.Previous = node1;
            //node1.Previous = null;

            //Console.WriteLine(node1.GetMax());

            //int[] nodes=new int[5];
            //int index = 0;
            //foreach (var item in node1)
            //{
            //    nodes[index]=item.Value;
            //    index++;
            //}
            //Console.WriteLine(nodes.Max());

            User fg = new User { Name = "飞哥" };
            User xy = new User { Name = "小鱼" };
            Keyword k1 = new Keyword { Name = "SQL" };
            Keyword k2 = new Keyword { Name = "C#" };
            Keyword k3 = new Keyword { Name = ".NET" };
            IList<Article> articles = new List<Article>()
            {
                new Article()
                {
                    Title = "飞哥1",
                    Author = fg,
                    PublishTime = new DateTime(2020 / 02 / 05),
                    KeyWords = new List<Keyword>() { k1 },
                    Comments = new List<Comment<Article>>() { new Comment<Article> { }, new Comment<Article> { } }
                },
                new Article()
                {
                    Title = "飞哥2",
                    Author = fg,
                    PublishTime = new DateTime(2018 / 07 / 07),
                    KeyWords = new List<Keyword>() { k2 },
                    Comments = new List<Comment<Article>>() { new Comment<Article> { } }
                },
                new Article()
                {
                    Title = "小鱼1",
                    Author = xy,
                    PublishTime = new DateTime(2018 / 01 / 01),
                    KeyWords = new List<Keyword>() { k3 },
                    Comments = new List<Comment<Article>>() { new Comment<Article> { }, new Comment<Article> { } }
                },
                new Article()
                {
                    Title = "小鱼2",
                    Author = xy,
                    PublishTime = new DateTime(2020 / 01 / 01),
                    KeyWords = new List<Keyword>() { k2,k3 },
                    Comments = new List<Comment<Article>>() { new Comment<Article> { } }
                }
            };
            //找出“飞哥”发布的文章
            //var result = from a in articles
            //        where a.Author.Name == "飞哥"
            //        select a;
            //找出2019年1月1日以后“小鱼”发布的文章
            //var result = from a in articles
            //        where a.PublishTime > new DateTime(2019 / 01 / 01) && a.Author.Name == "小鱼"
            //        select a;
            //按发布时间升序 / 降序排列显示文章
            //var result = from a in articles
            //        orderby a.PublishTime ascending
            //        select a;
            //var result = from a in articles
            //        orderby a.PublishTime descending
            //        select a;
            //统计每个用户各发布了多少篇文章
            //var result = from a in articles
            //        group a by a.Author;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Key.Name);
            //    Console.WriteLine(item.Count());
            //    foreach (var i in item)
            //    {
            //        Console.WriteLine(i.Title);
            //    }
            //}
            //找出包含关键字“C#”或“.NET”的文章
            //var result = from a in articles
            //             where a.KeyWords.Any(k => k.Name == "C#" || k.Name == ".NET")
            //             select a;
            //找出评论数量最多的文章
            //var result = from a in articles
            //        orderby a.Comments.Count descending
            //        select a;
            //result.First();
            //找出每个作者评论数最多的文章
            //var result = from a in articles
            //             group a by a.Author into am
            //             select am.OrderByDescending(am => am?.Comments.FirstOrDefault());
            //找出每个作者最近发布的一篇文章
            //var result = from a in articles
            //             group a by a.Author into ab
            //             select ab.OrderByDescending(ab => ab.PublishTime);
            IList<Problem> problems = new List<Problem>()
            {
                new Problem(){Title="p1", Reward=10, Author=fg},
                new Problem(){Title="p2", Reward=10, Author=fg},
                new Problem(){Title="p3", Reward=10, Author=xy},
                new Problem(){Title="p4", Reward=5, Author=xy},
            };
            //为求助（Problem）添加悬赏（Reward）属性，并找出每一篇求助的悬赏都大于5个帮帮币的求助作者
            //var result = from a in problems
            //             group a by a.Author into ac
            //             where ac.All(ac => ac.Reward > 5)
            //             select ac.Key.Name;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Main()函数调用ContentService时，捕获一切异常，并记录异常的消息和堆栈信息
            try
            {
                ContentService contentService = new ContentService();
                contentService.Publish(new Article());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString() + DateTime.Now);
            }
        }
        //泛型改造二分
        public static int BinarySearch<T>(T[] array, T target) where T : IComparable
        {
            int left = 0;
            int right = array.Length - 1;
            int middle;
            while (left <= right)
            {
                middle = (left + right) / 2;
                if (target.CompareTo(array[middle]) > 0)
                {
                    left = middle + 1;
                }
                else if (target.CompareTo(array[middle]) < 0)
                {
                    right = middle - 1;
                }
                else
                {
                    return middle;
                }
            }
            return -1;
        }
        //泛型改造取数组最大值
        public static T GetMax<T>(T[] array) where T : IComparable
        {
            T max = default;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].CompareTo(max) > 0)
                {
                    max = array[i];
                }//else
            }
            return max;
        }
        //修改Content的CreateTime和PublishTime
        public static void AlterCreateTime(Content content, DateTime datetime)
        {
            typeof(Content)
                .GetProperty(nameof(content.CreateTime), BindingFlags.NonPublic | BindingFlags.Instance)
                .SetValue(content, datetime);
        }
        public static void AlterPublishTime(Content content, DateTime datetime)
        {
            typeof(Content)
                .GetProperty(nameof(content.PublishTime), BindingFlags.NonPublic | BindingFlags.Instance)
                .SetValue(content, datetime);
        }
        //实现GetCount(string container, string target)方法，可以统计出container中有多少个target
        public static int GetCount(string container, string target)
        {
            int result = 0;
            //char[] contains = container.ToCharArray();

            for (int i = 0; i < container.Length; i++)
            {
                if (container[i] == target[0])
                {
                    if ((i + target.Length) > container.Length)
                    {
                        break;
                    }
                    else
                    {
                        if (container.Substring(i, target.Length) == target)
                        {
                            result += 1;
                        }//else
                    }
                }//else
            }
            //while (container.Contains(target))
            //{
            //    container = container.Substring(container.IndexOf(target) + target.Length);
            //    result += 1;
            //}
            return result;
        }
        //不使用string自带的Join()方法，定义一个mimicJoin()方法，能将若干字符串用指定的分隔符连接起来，比如：mimicJoin("-","a","b","c","d")，其运行结果为：a-b-c-d
        public static string MimicJoin(string separator, string[] value)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < value.Length; i++)
            {
                sb = sb.Append(value[i]);
                if (i != value.Length - 1)
                {
                    sb.Append(separator);
                }//else
            }
            return sb.ToString();
        }
    }
}
