using System;
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

            int[] arr = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(GetMax<int>(arr));

            Console.WriteLine(BinarySearch<int>(arr, 2));
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
