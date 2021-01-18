using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpLearn
{
    public class BangMoney : Entity
    {
        private DateTime Time { get; set; }
        private int Usable { get; set; }
        private int Freeza { get; set; }
        private string Kind { get; set; }
        private int Change { get; set; }
        private string Notes { get; set; }
        public User Owner { get; set; }

    }
}
