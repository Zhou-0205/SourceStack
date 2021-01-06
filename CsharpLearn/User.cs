using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpLearn
{
    public class User : Entity
    {
        public User Invitedby { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public Email Email { get; set; }
    }
}
