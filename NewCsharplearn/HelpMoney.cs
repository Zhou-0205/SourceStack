using System;
using System.Collections.Generic;
using System.Text;

namespace NewCsharplearn
{
    //帮帮币版块，定义一个类HelpMoney，表示一行帮帮币交易数据，包含你认为应该包含的字段和方法
    public class HelpMoney
    {
        //将之前的字段封装成属性

        private DateTime time;
        private int usable;
        private int freeza;
        private string kind;
        private int change;
        private string notes;
        private User owner;

        public DateTime Time { get; set; }
        public int Usable { get; set; }
        public int Freeza { get; set; }
        public string KInd { get; set; }
        public string Notes { get; set; }
        public User Owner { get; set; }

        public void Filtrate() { }
    }
}
