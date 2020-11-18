using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpLearn
{
    //一起帮里的求助总结、文章和意见建议，
    //以及他们的评论，都有一个点赞（Agree）/踩（Disagree）的功能，
    //赞和踩都会增减作者及评价者的帮帮点。能不能对其进行抽象？如何实现？
    public interface IPraise
    {
        public int AgreeAmount { get; set; }
        public int DisAgreeAmount { get; set; }
        void AgreeBy(User voter);
        void DisAgreeBy(User voter);
    }
}
