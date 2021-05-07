using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EFcore
{
    public class Problem : Content
    {
        public int Reward { get; set; }
        public IList<Keyword> Keywords { get; set; }
        public ProblemStatus Status { get; set; }
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
