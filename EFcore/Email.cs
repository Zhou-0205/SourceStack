using System;
using System.Collections.Generic;
using System.Text;

namespace EFcore
{
    public class Email : Entity
    {
        public string Title { get; set; }
        public string body { get; set; }
        public string EmailAddress { get; set; }
        public User Author { get; set; }
    }
}
