using System;

namespace Round
{
    class Program
    {
        static void Main(string[] args)
        {
            //for循环输出：1,2,3,4,5 和 1,3,5,7,9
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 1; i <= 9; i++)
            //{
            //    Console.WriteLine(i);
            //    i = i + 1;
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
            //    i = i + 1;
            //    Console.WriteLine(i);
            //    i++;
            //}
            //计算并输出：99 + 97 + 95 + 93 + ...+1的值
            //int sum = 0;
            //for (int i = 1; i <= 99; i++)
            //{
            //    Console.WriteLine(i);
            //    i = i + 1;
            //    sum += i;
            //}
            //Console.WriteLine(sum);
            //找到100以内的所有质数（只能被1和它自己整除的数）
            for (int i = 2; i <= 100; i++)
            {
                for (int k = 2; k <= i; k++)
                {
                    if (i % k == 0 && i != k)
                    {
                        break;
                    }
                    if (i % k == 0 && i == k)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            
        }   
    }
}
