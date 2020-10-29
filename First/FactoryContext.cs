using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
    public class FactoryContext
    {
        public static readonly FactoryContext _instance;

        static FactoryContext()
        {
            _instance = new FactoryContext();
        }

        private FactoryContext()
        {

        }
    }
}
