using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
    class Article:Content
    {
        public override void publish()
        {
            base.publish();
            Console.WriteLine();
        }
    }
}
