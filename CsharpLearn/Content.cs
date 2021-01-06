using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpLearn
{
    public abstract class Content : Entity
    {
        public string Kind { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime PublishTime { get { return DateTime.Now; } }
        public User Author { get; set; }
    }
}
