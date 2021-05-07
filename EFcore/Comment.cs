using System;
using System.Collections.Generic;
using System.Text;

namespace EFcore
{
    public class Comment : Entity
    {
        public User Author { get; set; }
        public string Body { get; set; }
    }
}
