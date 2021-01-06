using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpLearn
{
    //帮帮币版块，定义一个类HelpMoney，表示一行帮帮币交易数据，包含你认为应该包含的字段和方法
    public class HelpMoney : Entity
    {
        private DateTime Time { get; set; }
        private int Usable { get; set; }
        private int Freeza { get; set; }
        private string Kind { get; set; }
        private int Change { get; set; }
        private string Notes { get; set; }

    }
}
