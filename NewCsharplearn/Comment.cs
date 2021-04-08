using System;
using System.Collections.Generic;
using System.Text;

namespace NewCsharplearn
{
    public class Comment<T> : Content where T : Content
    {
        public string Content { get; set; }
        public T ContentType { get; set; }
        public Appraise<Comment<T>> Appraise { get; set; }
    }
}
