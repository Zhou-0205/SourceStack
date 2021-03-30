using System;
using System.Collections.Generic;
using System.Text;

namespace NewCsharplearn
{
    //帮帮币版块，定义一个类HelpMoney，表示一行帮帮币交易数据，包含你认为应该包含的字段和方法
    public class HelpMoney : Entity
    {
        //将之前的字段封装成属性

        //private DateTime time;
        //private int usable;
        //private int freeze;
        //private string kind;
        //private int change;
        //private string notes;
        //private User owner;

        public DateTime Time { get; set; }
        public int Usable { get; set; }
        public int Freeze { get; set; }
        public Variety Kind { get; set; }
        public int Change { get; set; }
        public string Notes { get; set; }
        public User Owner { get; set; }

        public static void Filtrate() { }
    }
    public enum Variety
    {
        Drop = 1,               //掉落
        Deal = 2,               //交易
        SeekHelp = 4,           //求助
        Advertising = 8,        //广告
        OnLoan = 16,            //借贷
        OnlyaReward = 32,       //打赏
        Urge = 64,              //督促
        PublishArticle = 128,   //文章发布
        Activity = 256          //活动
    }
}
