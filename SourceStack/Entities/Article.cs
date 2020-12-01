using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SourceStack.Entities
{
    public class Article : Entity
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime PublishTime { get; set; }
        public User Author { get; set; }
        public List<KeyWord> KeyWords { get; set; }
    }
}
