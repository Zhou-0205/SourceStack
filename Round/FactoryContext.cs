using System;
using System.Collections.Generic;
using System.Text;

namespace SELFstudy
{
    //设计一个类FactoryContext，保证整个程序运行过程中
    //外部只能获得它的唯一的一个实例化对象
    public class FactoryContext
    {
        private static readonly FactoryContext instance=new FactoryContext ();

        private FactoryContext()
        {

        }

        public static FactoryContext GetInstance()
        {
            return instance;
        }
    }
}
