using System;
using System.Collections.Generic;
using System.Text;

namespace EF
{
    public abstract class Content : Entity
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public User Author { get; set; }
        public ContentVariety Kind { get; set; }
        public IList<Comment> Comments { get; set; }
        public DateTime PublishTime { get { return DateTime.Now; } }
    }
    public enum ContentVariety
    {
        problem,
        article,
        suggest
    }
}
