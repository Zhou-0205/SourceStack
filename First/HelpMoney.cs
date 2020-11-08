using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
    //帮帮币版块，定义一个类HelpMoney，表示一行帮帮币交易数据，包含你认为应该包含的字段和方法
    class HelpMoney: Entity
    {
        private DateTime time { get; set; }
        private int useable { get; set; }
        private int freeza { get; set; }
        private string kind { get; set; }
        private int change { get; set; }
        private string notes { get; set; }

        public void gain(int num)
        {

        }
        public void freeze(int num)
        {

        }

    }
}
