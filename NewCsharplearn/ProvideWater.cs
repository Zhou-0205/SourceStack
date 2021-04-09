using System;
using System.Collections.Generic;
using System.Text;

namespace NewCsharplearn
{

    //声明一个委托：打水（ProvideWater），可以接受一个Person类的参数，返回值为int类型
    //使用：
    //    方法
    //    匿名方法
    //    lambda表达式
    //给上述委托赋值，并运行该委托
    //声明一个方法GetWater()，该方法接受ProvideWater作为参数，并能将ProvideWater的返回值输出

    public class Person
    {
        public string Name { get; set; }
        public static int Assign(Person person)
        {
            person.Name = "小王";
            return 1;
        }
        public int GetWater(ProvideWater provideWater)
        {
            Person person = new Person();
            return provideWater(person);
        }
        public static void ExecuteDelegate()
        {
            ProvideWater provideWater = new ProvideWater(Assign);

            provideWater += delegate (Person person)
             {
                 return 1;
             };

            provideWater += person => 1;

            provideWater(new Person());
        }
    }
    public delegate int ProvideWater(Person person);
}
