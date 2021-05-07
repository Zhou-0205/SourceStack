using System;
using System.Collections.Generic;
using System.Text;

namespace EFcore
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int FailedTry { get; set; }
    }
}
