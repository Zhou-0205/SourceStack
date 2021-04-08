using System;
using System.Collections.Generic;
using System.Text;

namespace NewCsharplearn
{
    public class Comment<T> : Content where T : Content
    {
        public T ContentType { get; set; }
        public Appraise<Comment<T>> Appraise { get; set; }
    }
}
