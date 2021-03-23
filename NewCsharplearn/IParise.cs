﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NewCsharplearn
{
    interface IParise
    {
        public int Agreeamount { get; set; }
        public int Disagreeamount { get; set; }
        void Agree(User voter);
        void Disagree(User voter);
    }
}
