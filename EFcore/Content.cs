using System;
using System.Collections.Generic;
using System.Text;

namespace EFcore
{
    public class Content : Entity
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public User Author { get; set; }
        public IList<Comment> Comments { get; set; }
        public DateTime PublishTime { get; set; }
    }
}
