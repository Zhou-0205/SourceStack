using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpLearn
{
    public class Suggest : Content
    {
        public int Reward { get; set; }
        public override void Release()
        {
            Console.WriteLine("不需要消耗帮帮币");
        }
    }
}
