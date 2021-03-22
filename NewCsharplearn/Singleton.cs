using System;
using System.Collections.Generic;
using System.Text;

namespace NewCsharplearn
{
    //设计一个类，保证整个程序运行过程中，无论如何，外部只能获得它的唯一的一个实例化对象
    public class Singleton
    {
        private static readonly Singleton uniqueInstance = new Singleton();
        private Singleton()
        { }
        public static Singleton GetInstance()
        {
            return uniqueInstance;
        }
    }
}
