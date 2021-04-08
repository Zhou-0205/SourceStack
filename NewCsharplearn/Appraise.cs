using System;
using System.Collections.Generic;
using System.Text;

namespace NewCsharplearn
{
    public class Appraise<T> where T : Content
    {
        public Direction IsAgree { get; set; }
        public T ContentType { get; set; }
        public User Voter { get; set; }
    }
    public enum Direction
    {
        up,
        down
    }
}
