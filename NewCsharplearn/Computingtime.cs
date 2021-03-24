using System;
using System.Collections.Generic;
using System.Text;

namespace NewCsharplearn
{
    public class Computingtime
    {
        //函数GetDate()，能计算一个日期若干（日/周/月）后的日期
        public static DateTime GetDate(DateTime dateTime, int amount, Kind kind)
        {
            switch (kind)
            {
                case Kind.day:
                    dateTime = dateTime.AddDays(amount);
                    break;
                case Kind.week:
                    dateTime = dateTime.AddDays(amount * 7);
                    break;
                case Kind.month:
                    dateTime = dateTime.AddMonths(amount);
                    break;
                default:
                    break;
            }
            return dateTime;
        }


        //给定任意一个年份，就能按周排列显示每周的起始日期
        public static DateTime GetFirstMondy(int year)
        {
            DateTime datetime = new DateTime(year, 01, 01);
            while (datetime.DayOfWeek != DayOfWeek.Monday)
            {
                datetime = datetime.AddDays(1);
            }
            return datetime;
        }
        public static void GetWeeks(DateTime start)
        {
            int year = start.Year + 1;
            int i = 1;
            while (start.Year < year)
            {
                Console.WriteLine($"第{i}周,{start.ToString("yyyy年MM月dd日")}——{start.AddDays(6).ToString("yyyy年MM月dd日")}");
                i++;
                start = start.AddDays(7);
            }
        }
    }
    public enum Kind
    {
        day = 0,
        week = 1,
        month = 2
    }
}
