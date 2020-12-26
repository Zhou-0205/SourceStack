using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CsharpLearn
{
    public class Problem : Content
    {
        public int Reward { get; set; }
        public ProblemStatus Status{ get; set; }
    }
    public enum ProblemStatus
    {
        [Description("已撤销")]
        cancelled,
        [Description("以酬谢")]
        rewarded,
        [Description("协助中")]
        assinting,
        [Description("待协助")]
        pending
    }
}
