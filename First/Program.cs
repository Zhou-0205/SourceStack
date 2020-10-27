using System;
using System.Dynamic;

namespace First
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //用户依次由控制台输入：验证码、用户名和密码：
            //  如果验证码输入错误，直接输出：“*验证码错误”；
            //  如果用户名不存在，直接输出：“*用户名不存在”；
            //  如果用户名或密码错误，输出：“*用户名或密码错误”
            //  以上全部正确无误，输出：“恭喜！登录成功！”
            //string code = "xyz0", name = "小李", password = "123456";
            //Console.WriteLine("请输入验证码");
            //string usecode = Console.ReadLine();
            //if (usecode == code)
            //{
            //    Console.WriteLine("请输入用户名");
            //    string usename = Console.ReadLine();
            //    if (usename == name)
            //    {
            //        Console.WriteLine("请输入密码");
            //        string usepassword = Console.ReadLine();
            //        if (usepassword == password)
            //        {
            //            Console.WriteLine("恭喜，登录成功");
            //        }
            //        else
            //        {
            //            Console.WriteLine("用户名或密码错误");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("用户名不存在");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("验证码错误");
            //}
            //for循环输出：1,2,3,4,5 和 1,3,5,7,9
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 1; i <= 9; i+=2)
            //{
            //    Console.WriteLine(i);
            //}
            //while循环输出：1,2,3,4,5 和 1,3,5,7,9
            //int i = 0;
            //while (i<5)
            //{
            //    i++;
            //    Console.WriteLine(i);
            //}
            //int i = 0;
            //while (i <= 9)
            //{
            //    Console.WriteLine(i);
            //    i+=2;
            //}
            //用for循环输出存储在一维 / 二维数组里的源栈所有同学姓名 / 昵称
            //string[] name = new string[] { "刘伟", "龚廷义", "周丁浩", "李智博", "廖光银" };
            //string[,] seatname = new string[2,3];
            //for (int i = 0; i < seatname.GetLength(0); i++)
            //{
            //    for (int j = 0; j < seatname.GetLength(1); j++)
            //    {
            //        Console.WriteLine(seatname[i,j]);
            //    }
            //}
            //计算并输出：99 + 97 + 95 + 93 + ...+1的值
            //int sum = 0;
            //for (int i = 1; i <= 99; i+=2)
            //{
            //    Console.WriteLine(i);
            //    sum += i;
            //}
            //Console.WriteLine(sum);
            //找到100以内的所有质数（只能被1和它自己整除的数）
            //for (int i = 2; i <= 100; i++)
            //{
            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            break;
            //        }
            //        //else continue；
            //        if (i - 1 == j)
            //        {
            //            Console.WriteLine(i);
            //        }
            //        //else nothing；
            //    }
            //}
            //将源栈同学的成绩存入一个double数组中，用循环找到最高分和最低分
            //double[] score = {73.5,85.55,88.75,90.8,65.4};
            //double max = score[0];
            //for (int i = 0; i < score.Length; i++)
            //{
            //    if (score[i]>max)
            //    {
            //        max = score[i];
            //    }//else
            //}
            //Console.WriteLine(max);
            //double min = score[0];
            //for (int i = 0; i < score.Length; i++)
            //{
            //    if (score[i] > min)
            //    {
            //        min = score[i];
            //    }//else
            //}
            //Console.WriteLine(min);
            //生成一个元素（值随机）从小到大排列的数组
            //int[] a = new int[10];
            //random ran = new random();
            //for (int i = 0; i < 10; i++)
            //{
            //    a[i] = ran.next(100);
            //}
            //array.sort(a);
            //for (int i = 0; i < 10; i++)
            //{
            //    console.writeline(a[i]);
            //}
            //设立并显示一个多维数组的值，元素值等于下标之和
            //static void twoDimensional()
            //{
            //    int[,] sum = new int[8, 5];
            //    for (int i = 0; i < sum.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < sum.GetLength(1); j++)
            //        {
            //            sum[i, j] = i + j;
            //        }
            //    }
            //    for (int k = 0; k < sum.GetLength(0); k++)
            //    {
            //        for (int l = 0; l < sum.GetLength(1); l++)
            //        {
            //            Console.Write(sum[k, l] + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //}

            //将之前作业封装成方法（自行思考参数和返回值），并调用执行
            //static void findPrimeNum(int start, int end)
            //{
            //    for (int i = start; i < end; i++)
            //    {
            //        for (int j = 2; j < i; j++)
            //        {
            //            if (i % j == 0)
            //            {
            //                break;
            //            }//else nothing
            //            if (i - 1 == j)
            //            {
            //                Console.WriteLine(i);
            //            }//else nothing
            //        }
            //    }
            //}
            
        }
        //计算得到源栈同学的平均成绩（精确到两位小数），方法名GetAverage()
        static double GetAverage(double[] scores)
        {
            double sum = 0;
            double avg;
            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }
            avg = sum / scores.Length;

            avg = Math.Round((sum / scores.Length), 2);
            return avg;
        }
        //完成“猜数字”游戏，方法名GuessMe()：
        //  随机生成一个大于0小于1000的整数
        //  用户输入一个猜测值，系统进行判断，告知用户猜测的数是“大了”，还是“小了”
        //  没猜中可以继续猜，但最多不能超过10次
        //      如果5次之内猜中，输出：你真牛逼！
        //      如果8次之内猜中，输出：不错嘛！
        //      10次还没猜中，输出：(～￣(OO)￣)ブ
        static void GuessMe(int input)
        {
            int num = new Random().Next(1000);
            Console.WriteLine("随机数是：" + num);
            for (int i = 1; i < 11; i++)
            {
                input = Convert.ToInt32(Console.ReadLine());
                if (input != num)
                {
                    if (i == 10)
                    {
                        Console.WriteLine("～￣(OO)￣");
                    }
                    else if (input > num)
                    {
                        Console.WriteLine($"太大了!还剩{10 - i}次");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"太小了!还剩{10 - i}次");
                        continue;
                    }
                }
                else
                {
                    if (i <= 5)
                    {
                        Console.WriteLine("你真牛逼");
                    }
                    else if (i <= 8)
                    {
                        Console.WriteLine("不错嘛");
                    }
                    else
                    {
                        Console.WriteLine("太笨了！");
                    }
                    break;
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

        //定义一个生成数组的方法：int[] GetArray()，其元素随机生成从小到大排列。
        //利用可选参数控制：
        //  最小值min（默认为1）
        //  相邻两个元素之间的最大差值gap（默认为5）
        //  元素个数length（默认为10个）
        public static int[] GetArray(int min = 1, int gap = 5, int length = 10)
        {
            int[] array = new int[length];
            Random ran = new Random();
            array[0] = ran.Next(min);
            Console.WriteLine(array[0]);
            for (int i = 1; i < array.Length; i++)
            {
                array[i] = ran.Next(gap) + array[i - 1];
                Console.WriteLine(array[i]);
            }
            return array;
        }

        //将登陆的过程封装成一个方法LogOn()，调用之后能够获得：
        //  true / false，表示登陆是否成功
        //  string，表示登陆失败的原因
        //static bool logOn(string authCode, string userName, string password,string output)
        //{
        //    Console.WriteLine($"请输入验证码{authCode}");
        //    if (Console.ReadLine() == authCode)
        //    {
        //        Console.WriteLine($"请输入用户名{userName}");
        //        if (Console.ReadLine() == userName)
        //        {
        //            Console.WriteLine($"请输入密码{password}");
        //            if (Console.ReadLine() == password)
        //            {
        //                return true;
        //            }
        //            else
        //            {
        //                output = "用户名或密码错误";
        //                return false;
        //            }
        //        }
        //        else
        //        {
        //            output = "用户名不存在";
        //            return false;
        //        }
        //    }
        //    else
        //    {
        //        output = "验证码错误";
        //        return false;
        //    }
        //}


    }
}

