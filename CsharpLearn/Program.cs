using System;

namespace CsharpLearn
{
    class Program
    {
        //计算得到源栈同学的平均成绩（精确到两位小数),方法名GetAverage()
        static double GetAverage(double[] scores)
        {
            double sum = 0;
            double avg;
            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }
            avg = Math.Round((sum / scores.Length), 2);
            return avg;
        }

        //完成“猜数字”游戏，方法名GuessMe()：
        //  随机生成一个大于0小于1000的整数
        //  用户输入一个猜测值，系统进行判断，告知用户猜测的数是“大了”，还是“小了”
        //  保证输入数值可以转换为整数
        //  没猜中可以继续猜，但最多不能超过10次
        //  如果5次之内猜中，输出：你真牛逼！
        //  如果8次之内猜中，输出：不错嘛！
        //  10次还没猜中，输出：(～￣(OO)￣)ブ
        static void GuessMe()
        {
            int generate = new Random().Next(0, 1000);
            for (int i = 1; i <= 10; i++)
            {
                if (int.TryParse(Console.ReadLine(), out int input))
                {
                    if (input != generate)
                    {
                        if (i == 10)
                        {
                            Console.WriteLine("(～￣(OO)￣)ブ");
                        }
                        else if (input > generate)
                        {
                            Console.WriteLine($"太大了，还有{10 - i}次");
                        }
                        else
                        {
                            Console.WriteLine($"太小了，还有{10 - i}次");
                        }
                    }
                    else
                    {
                        if (i <= 5)
                        {
                            Console.WriteLine($"猜对了，用了{i}次，真厉害");
                        }
                        else if (i <= 8)
                        {
                            Console.WriteLine($"猜对了，用了{i}次，还不错");
                        }
                        else
                        {
                            Console.WriteLine($"猜对了，用了{i}次，勉强过关");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("输入有误");
                    return;
                }
            }

        }

        //利用ref调用Swap()方法交换两个同学的床位号
        static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        //将登陆的过程封装成一个方法LogOn()，调用之后能够获得：
        //  true/false，表示登陆是否成功
        //  string，表示登陆失败的原因
        static bool LogOn(out string output)
        {
            Console.WriteLine("请输入验证码");
            if (Console.ReadLine() != "2h4j")
            {
                output = "验证码错误";
                return false;
            }
            else
            {
                Console.WriteLine("请输入用户名");
                if (Console.ReadLine() != "zdh")
                {
                    output = "用户名错误";
                    return false;
                }
                else
                {
                    Console.WriteLine("请输入密码");
                    if (Console.ReadLine() != "123456")
                    {
                        output = "用户名或密码错误";
                        return false;
                    }
                    else
                    {
                        output = "登录成功";
                        return true;
                    }
                }
            }
        }

        //定义一个生成数组的方法：int[] GetArray()，其元素随机生成从小到大排列。
        //利用可选参数控制：
        //  最小值min（默认为1）
        //  相邻两个元素之间的最大差值gap（默认为5）
        //  元素个数length（默认为10个）
        static int[] GetArray(int min = 1, int gap = 5, int length = 10)
        {
            int[] array = new int[length];
            Random ran = new Random();
            array[0] = min;
            Console.WriteLine(array[0]);
            for (int i = 1; i < array.Length; i++)
            {
                array[i] = ran.Next(min, gap) + array[i - 1];
                Console.WriteLine(array[i]);
            }
            return array;
        }

        //实现二分查找，方法名BinarySeek(int[] numbers, int target)：
        //  传入一个有序（从大到小/从小到大）数组和数组中要查找的元素
        //  如果找到，返回该元素所在的下标；否则，返回-1
        static void Main(string[] args)
        {
            //FactoryContext.GetInstance();

            //调用这些类的有参 / 无参构造函数，生成这些类的对象，调用他们的方法
            //User zdh = new User("周丁浩","123qwe");
            //User.Login(zdh.Name);

            //Problem word = new Problem("");
            //Console.WriteLine(word[1]);

            //HelpMoney hm = new HelpMoney();
            //hm.freeze(10);

            //GetArray();

            //string reason;
            //LogOn(out reason);
            //Console.WriteLine(reason);

            //int a = 23, b = 34;
            //swap(ref a, ref b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //GuessMe();

            //Console.WriteLine(GetAverage(new double[] { 98, 97, 96, 95.5 }));

            //  将源栈同学姓名 / 昵称分别：
            //  按进栈时间装入一维数组，
            //  按座位装入二维数组，
            //  并输出共有多少名同学
            //string[] name = { "智博", "廷义", "丁浩", "光银", "刘伟", "邹丽" };
            //string[,] seat = new string[2, 4];
            //seat[0, 0] = "智博";
            //seat[0, 1] = "丁浩";
            //seat[0, 2] = "刘伟";
            //seat[0, 3] = "廷义";
            //seat[1, 0] = "邹丽";
            //seat[1, 2] = "光银";
            //Console.WriteLine(seat.Length);

            //分别用for循环和while循环输出：1,2,3,4,5 和 1,3,5,7,9
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 1; i < 10; i+=2)
            //{
            //    Console.WriteLine(i);
            //}
            //int i = 0;
            //while (i < 5)
            //{
            //    i++;
            //    Console.WriteLine(i);
            //}
            //int i=1;
            //while (i<10)
            //{
            //    Console.WriteLine(i);
            //    i += 2;
            //}
            //用for循环输出存储在一维 / 二维数组里的源栈所有同学姓名 / 昵称
            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}
            //for (int i = 0; i < seat.GetLength(0); i++)
            //{
            //    for (int j = 0; j < seat.GetLength(1); j++)
            //    {
            //        Console.WriteLine(seat[i, j]);
            //    }
            //}
            //让电脑计算并输出：99 + 97 + 95 + 93 + ...+1的值
            //int sum = 0;
            //for (int i = 1; i < 100; i+=2)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);
            //将源栈同学的成绩存入一个double数组中，用循环找到最高分和最低分
            //double[] score = { 97.5, 95, 92.5, 90 ,98};
            //double max = score[0];
            //for (int i = 0; i < score.Length; i++)
            //{
            //    if (score[i]>max)
            //    {
            //        max = score[i];
            //    }
            //}
            //Console.WriteLine(max);
            //double min = score[0];
            //for (int i = 0; i < score.Length; i++)
            //{
            //    if (score[i]<min)
            //    {
            //        min = score[i];
            //    }
            //}
            //Console.WriteLine(min);
            //找到100以内的所有质数（只能被1和它自己整除的数)
            //for (int i = 2; i <= 100; i++)
            //{
            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            break;
            //        }
            //        //else
            //        if (i - 1 == j)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}
            //生成一个元素（值随机）从小到大排列的数组
            //int[] array = new int[10];
            //Random ran = new Random();
            //array[0] = ran.Next(100);
            //Console.WriteLine(array[0]);
            //for (int i = 1; i < array.Length; i++)
            //{
            //    array[i] = ran.Next(100)+array[i-1];
            //    Console.WriteLine(array[i]);
            //}
            //设立并显示一个多维数组的值，元素值等于下标之和

            //int[,] sum = new int[3, 5];
            //for (int i = 0; i < sum.GetLength(0); i++)
            //{
            //    for (int j = 0; j < sum.GetLength(1); j++)
            //    {
            //        sum[i, j] = i + j;
            //        Console.Write(sum[i,j]+" ");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
