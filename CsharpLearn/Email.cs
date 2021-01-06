using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpLearn
{
    public class Email : Entity
    {
        public string Title { get; set; }
        public string body { get; set; }
        public User Author { get; set; }
    }
}
