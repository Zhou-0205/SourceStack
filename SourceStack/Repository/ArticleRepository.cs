using SourceStack.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SourceStack.Repository
{
    public class ArticleRepository
    {
        private static IList<Article> articles;
        public ArticleRepository()
        {
            articles = new List<Article>
            {
                new Article
                {
                    Id=1,
                    Title=@"高阶：泛型 / 集合 / Lambda / 异常 / IO / 多线程",
                    Body=@"泛型可以有泛型方法/类等，同C#可以有约束public class 
                    Student<T extends IMajor> extends Person {子类继承时：
                    public class OnlineStudent<T extends IMajor> extends 
                    Student<T > {协变/逆变通配符：？实现extends：协变（out）super：
                    逆变（in）Optional 类对应NullableOptional<Integer> age =",
                    PublishTime =DateTime.Now,
                    KeyWords= new List<KeyWord>
                    {
                        new KeyWord{Name="Java"},
                        new KeyWord{Name="C#"},
                        new KeyWord{Name="对比"},
                        new KeyWord{Name="高阶语法"}
                    },
                    Author=new User
                    {
                        Id=1,
                        Name="小刘",
                    }
                },
                new Article
                {
                    Id=2,
                    Title=@"异步方法和TPL： async / await / Parallel",
                    Body=@"封装我们要把上面这个Task封装成方法，怎么办？最重要的一点，
                    这个方法要能返回生成的random，后面的代码要用！public static Task
                    <int> getRandom(){return Task<int>.Run(() =>{Thread.Sleep(500)
                    ; //模拟耗时return new Random().Next();});}@想一想@：应该如何调
                    用这个方法？（提示：不要直接getRandom().Result） 假如我们还需要进
                    一步的封装，添加 ",
                    PublishTime =DateTime.Now,
                    KeyWords= new List<KeyWord>
                    {
                        new KeyWord
                        {
                            Name="异步方法"
                        },
                        new KeyWord
                        {
                            Name="async"
                        },
                        new KeyWord
                        {
                            Name="await"
                        },
                        new KeyWord
                        {
                            Name="并发"
                        }
                    },
                    Author=new User
                    {
                        Id=1,
                        Name="小刘",
                    }
                },
                new Article
                {
                    Id=3,
                    Title=@"面向对象：类和对象/封装/继承/多态/抽象接口/枚举/反射/String",
                    Body=@"类和对象 类文件后缀：.java包（namespace）：项目上右键
                    创建package _17bang.CD.Yz;引入（using）import _17bang.YZ.
                    Student;没有partial类访问修饰符：没有关键字internal（不能显式声
                    明，默认即可，package中可见）static：可以由对象调用（只warning不
                    报错)引用类型和值类型其他类成员快捷键生成：alt+shift+s，构造函数
                    间调用：public Student(int age) {this();}没有属性，只有get",
                    PublishTime =DateTime.Now,
                    KeyWords= new List<KeyWord>
                    {
                        new KeyWord
                        {
                            Name="源栈培训"
                        },
                        new KeyWord
                        {
                            Name="C#"
                        },
                        new KeyWord
                        {
                            Name="语法"
                        },
                        new KeyWord
                        {
                            Name="类"
                        },
                        new KeyWord
                        {
                            Name="对象"
                        }
                    },
                    Author=new User
                    {
                        Id=1,
                        Name="小刘",
                    }
                },
                new Article
                {
                    Id=4,
                    Title=@"C#-面向对象：string还是StringBuilder？",
                    Body=@"我们之前故意对string一带而过，是因为它非常特别。首先，它是
                    imutable（不可变的）即一个string定义的字符串，一旦设定，就不能改
                    变。在string上直接F12转到定义，就可以看到String类的成员。其中，只
                    有一个只读的静态成员Empty（建议使用，以替代null和空字符串""）：
                    public static readonly String Empty;一个只读的索引器，可以获取
                    字符串中某个下标的字符：public char this[int index] { get; }
                    一个只读的属性Len",
                    PublishTime =DateTime.Now,
                    KeyWords= new List<KeyWord>
                    {
                        new KeyWord
                        {
                            Name="源栈培训"
                        },
                        new KeyWord
                        {
                            Name="C#"
                        },
                        new KeyWord
                        {
                            Name="语法"
                        },
                        new KeyWord
                        {
                            Name="类"
                        },
                        new KeyWord
                        {
                            Name="对象"
                        }
                    },
                    Author=new User
                    {
                        Id=1,
                        Name="小刘",
                    }
                },
                new Article
                {
                    Id=5,
                    Title=@"C#-面向对象：争议TDD（测试驱动开发）",
                    Body=@"在谈到特性的使用场景时，还有一个绝对离不开的就是单元测试按
                    飞哥的定义，单元测试是开发人员自己用代码实现的测试。注意这个定义，
                    其核心在于：主体是“开发人员”，不是测试人员。途径是“通过代码实现”，
                    不是通过手工测试。实质是一种“测试”，不是代码调试。暂时还有点抽象，
                    同学们记着这个概念，我们先用一个NUnit项目来看一看单元测试长个什么
                    样。在solution上右键添加项目，选择Test中的NUnit Test Project，
                    输入项目名称，点击OK：Visual Studio直接集成了NUnit说明微软在开源和",
                    PublishTime =DateTime.Now,
                    KeyWords= new List<KeyWord>
                    {
                        new KeyWord
                        {
                            Name="源栈培训"
                        },
                        new KeyWord
                        {
                            Name="C#"
                        },
                        new KeyWord
                        {
                            Name="语法"
                        },
                        new KeyWord
                        {
                            Name="类"
                        },
                        new KeyWord
                        {
                            Name="对象"
                        }
                    },
                    Author=new User
                    {
                        Id=1,
                        Name="小刘",
                    }
                },
                new Article
                {
                    Id=6,
                    Title=@"C#-面向对象：争议TDD（测试驱动开发）",
                    Body=@"在谈到特性的使用场景时，还有一个绝对离不开的就是单元测试按
                    飞哥的定义，单元测试是开发人员自己用代码实现的测试。注意这个定义，
                    其核心在于：主体是“开发人员”，不是测试人员。途径是“通过代码实现”，
                    不是通过手工测试。实质是一种“测试”，不是代码调试。暂时还有点抽象，
                    同学们记着这个概念，我们先用一个NUnit项目来看一看单元测试长个什么
                    样。在solution上右键添加项目，选择Test中的NUnit Test Project，
                    输入项目名称，点击OK：Visual Studio直接集成了NUnit说明微软在开源和",
                    PublishTime =DateTime.Now,
                    KeyWords= new List<KeyWord>
                    {
                        new KeyWord
                        {
                            Name="源栈培训"
                        },
                        new KeyWord
                        {
                            Name="C#"
                        },
                        new KeyWord
                        {
                            Name="语法"
                        },
                        new KeyWord
                        {
                            Name="类"
                        },
                        new KeyWord
                        {
                            Name="对象"
                        }
                    },
                    Author=new User
                    {
                        Id=1,
                        Name="小刘",
                    }
                },
                new Article
                {
                    Id=7,
                    Title=@"C#-面向对象：争议TDD（测试驱动开发）",
                    Body=@"在谈到特性的使用场景时，还有一个绝对离不开的就是单元测试按
                    飞哥的定义，单元测试是开发人员自己用代码实现的测试。注意这个定义，
                    其核心在于：主体是“开发人员”，不是测试人员。途径是“通过代码实现”，
                    不是通过手工测试。实质是一种“测试”，不是代码调试。暂时还有点抽象，
                    同学们记着这个概念，我们先用一个NUnit项目来看一看单元测试长个什么
                    样。在solution上右键添加项目，选择Test中的NUnit Test Project，
                    输入项目名称，点击OK：Visual Studio直接集成了NUnit说明微软在开源和",
                    PublishTime =DateTime.Now,
                    KeyWords= new List<KeyWord>
                    {
                        new KeyWord
                        {
                            Name="源栈培训"
                        },
                        new KeyWord
                        {
                            Name="C#"
                        },
                        new KeyWord
                        {
                            Name="语法"
                        },
                        new KeyWord
                        {
                            Name="类"
                        },
                        new KeyWord
                        {
                            Name="对象"
                        }
                    },
                    Author=new User
                    {
                        Id=1,
                        Name="小刘",
                    }
                },
                new Article
                {
                    Id=8,
                    Title=@"C#-面向对象：争议TDD（测试驱动开发）",
                    Body=@"在谈到特性的使用场景时，还有一个绝对离不开的就是单元测试按
                    飞哥的定义，单元测试是开发人员自己用代码实现的测试。注意这个定义，
                    其核心在于：主体是“开发人员”，不是测试人员。途径是“通过代码实现”，
                    不是通过手工测试。实质是一种“测试”，不是代码调试。暂时还有点抽象，
                    同学们记着这个概念，我们先用一个NUnit项目来看一看单元测试长个什么
                    样。在solution上右键添加项目，选择Test中的NUnit Test Project，
                    输入项目名称，点击OK：Visual Studio直接集成了NUnit说明微软在开源和",
                    PublishTime =DateTime.Now,
                    KeyWords= new List<KeyWord>
                    {
                        new KeyWord
                        {
                            Name="源栈培训"
                        },
                        new KeyWord
                        {
                            Name="C#"
                        },
                        new KeyWord
                        {
                            Name="语法"
                        },
                        new KeyWord
                        {
                            Name="类"
                        },
                        new KeyWord
                        {
                            Name="对象"
                        }
                    },
                    Author=new User
                    {
                        Id=1,
                        Name="小刘",
                    }
                },
                new Article
                {
                    Id=9,
                    Title=@"高阶：泛型 / 集合 / Lambda / 异常 / IO / 多线程",
                    Body=@"泛型可以有泛型方法/类等，同C#可以有约束public class 
                    Student<T extends IMajor> extends Person {子类继承时：
                    public class OnlineStudent<T extends IMajor> extends 
                    Student<T > {协变/逆变通配符：？实现extends：协变（out）super：
                    逆变（in）Optional 类对应NullableOptional<Integer> age =",
                    PublishTime =DateTime.Now,
                    KeyWords= new List<KeyWord>
                    {
                        new KeyWord{Name="Java"},
                        new KeyWord{Name="C#"},
                        new KeyWord{Name="对比"},
                        new KeyWord{Name="高阶语法"}
                    },
                    Author=new User
                    {
                        Id=1,
                        Name="小刘",
                    }
                },
                new Article
                {
                    Id=10,
                    Title=@"异步方法和TPL： async / await / Parallel",
                    Body=@"封装我们要把上面这个Task封装成方法，怎么办？最重要的一点，
                    这个方法要能返回生成的random，后面的代码要用！public static Task
                    <int> getRandom(){return Task<int>.Run(() =>{Thread.Sleep(500)
                    ; //模拟耗时return new Random().Next();});}@想一想@：应该如何调
                    用这个方法？（提示：不要直接getRandom().Result） 假如我们还需要进
                    一步的封装，添加 ",
                    PublishTime =DateTime.Now,
                    KeyWords= new List<KeyWord>
                    {
                        new KeyWord
                        {
                            Name="异步方法"
                        },
                        new KeyWord
                        {
                            Name="async"
                        },
                        new KeyWord
                        {
                            Name="await"
                        },
                        new KeyWord
                        {
                            Name="并发"
                        }
                    },
                    Author=new User
                    {
                        Id=1,
                        Name="小刘",
                    }
                },
                new Article
                {
                    Id=11,
                    Title=@"面向对象：类和对象/封装/继承/多态/抽象接口/枚举/反射/String",
                    Body=@"类和对象 类文件后缀：.java包（namespace）：项目上右键
                    创建package _17bang.CD.Yz;引入（using）import _17bang.YZ.
                    Student;没有partial类访问修饰符：没有关键字internal（不能显式声
                    明，默认即可，package中可见）static：可以由对象调用（只warning不
                    报错)引用类型和值类型其他类成员快捷键生成：alt+shift+s，构造函数
                    间调用：public Student(int age) {this();}没有属性，只有get",
                    PublishTime =DateTime.Now,
                    KeyWords= new List<KeyWord>
                    {
                        new KeyWord
                        {
                            Name="源栈培训"
                        },
                        new KeyWord
                        {
                            Name="C#"
                        },
                        new KeyWord
                        {
                            Name="语法"
                        },
                        new KeyWord
                        {
                            Name="类"
                        },
                        new KeyWord
                        {
                            Name="对象"
                        }
                    },
                    Author=new User
                    {
                        Id=1,
                        Name="小刘",
                    }
                },
                new Article
                {
                    Id=12,
                    Title=@"C#-面向对象：string还是StringBuilder？",
                    Body=@"我们之前故意对string一带而过，是因为它非常特别。首先，它是
                    imutable（不可变的）即一个string定义的字符串，一旦设定，就不能改
                    变。在string上直接F12转到定义，就可以看到String类的成员。其中，只
                    有一个只读的静态成员Empty（建议使用，以替代null和空字符串""）：
                    public static readonly String Empty;一个只读的索引器，可以获取
                    字符串中某个下标的字符：public char this[int index] { get; }
                    一个只读的属性Len",
                    PublishTime =DateTime.Now,
                    KeyWords= new List<KeyWord>
                    {
                        new KeyWord
                        {
                            Name="源栈培训"
                        },
                        new KeyWord
                        {
                            Name="C#"
                        },
                        new KeyWord
                        {
                            Name="语法"
                        },
                        new KeyWord
                        {
                            Name="类"
                        },
                        new KeyWord
                        {
                            Name="对象"
                        }
                    },
                    Author=new User
                    {
                        Id=1,
                        Name="小刘",
                    }
                },
                new Article
                {
                    Id=13,
                    Title=@"C#-面向对象：争议TDD（测试驱动开发）",
                    Body=@"在谈到特性的使用场景时，还有一个绝对离不开的就是单元测试按
                    飞哥的定义，单元测试是开发人员自己用代码实现的测试。注意这个定义，
                    其核心在于：主体是“开发人员”，不是测试人员。途径是“通过代码实现”，
                    不是通过手工测试。实质是一种“测试”，不是代码调试。暂时还有点抽象，
                    同学们记着这个概念，我们先用一个NUnit项目来看一看单元测试长个什么
                    样。在solution上右键添加项目，选择Test中的NUnit Test Project，
                    输入项目名称，点击OK：Visual Studio直接集成了NUnit说明微软在开源和",
                    PublishTime =DateTime.Now,
                    KeyWords= new List<KeyWord>
                    {
                        new KeyWord
                        {
                            Name="源栈培训"
                        },
                        new KeyWord
                        {
                            Name="C#"
                        },
                        new KeyWord
                        {
                            Name="语法"
                        },
                        new KeyWord
                        {
                            Name="类"
                        },
                        new KeyWord
                        {
                            Name="对象"
                        }
                    },
                    Author=new User
                    {
                        Id=1,
                        Name="小刘",
                    }
                },
                new Article
                {
                    Id=14,
                    Title=@"C#-面向对象：争议TDD（测试驱动开发）",
                    Body=@"在谈到特性的使用场景时，还有一个绝对离不开的就是单元测试按
                    飞哥的定义，单元测试是开发人员自己用代码实现的测试。注意这个定义，
                    其核心在于：主体是“开发人员”，不是测试人员。途径是“通过代码实现”，
                    不是通过手工测试。实质是一种“测试”，不是代码调试。暂时还有点抽象，
                    同学们记着这个概念，我们先用一个NUnit项目来看一看单元测试长个什么
                    样。在solution上右键添加项目，选择Test中的NUnit Test Project，
                    输入项目名称，点击OK：Visual Studio直接集成了NUnit说明微软在开源和",
                    PublishTime =DateTime.Now,
                    KeyWords= new List<KeyWord>
                    {
                        new KeyWord
                        {
                            Name="源栈培训"
                        },
                        new KeyWord
                        {
                            Name="C#"
                        },
                        new KeyWord
                        {
                            Name="语法"
                        },
                        new KeyWord
                        {
                            Name="类"
                        },
                        new KeyWord
                        {
                            Name="对象"
                        }
                    },
                    Author=new User
                    {
                        Id=1,
                        Name="小刘",
                    }
                },
                new Article
                {
                    Id=15,
                    Title=@"C#-面向对象：争议TDD（测试驱动开发）",
                    Body=@"在谈到特性的使用场景时，还有一个绝对离不开的就是单元测试按
                    飞哥的定义，单元测试是开发人员自己用代码实现的测试。注意这个定义，
                    其核心在于：主体是“开发人员”，不是测试人员。途径是“通过代码实现”，
                    不是通过手工测试。实质是一种“测试”，不是代码调试。暂时还有点抽象，
                    同学们记着这个概念，我们先用一个NUnit项目来看一看单元测试长个什么
                    样。在solution上右键添加项目，选择Test中的NUnit Test Project，
                    输入项目名称，点击OK：Visual Studio直接集成了NUnit说明微软在开源和",
                    PublishTime =DateTime.Now,
                    KeyWords= new List<KeyWord>
                    {
                        new KeyWord
                        {
                            Name="源栈培训"
                        },
                        new KeyWord
                        {
                            Name="C#"
                        },
                        new KeyWord
                        {
                            Name="语法"
                        },
                        new KeyWord
                        {
                            Name="类"
                        },
                        new KeyWord
                        {
                            Name="对象"
                        }
                    },
                    Author=new User
                    {
                        Id=1,
                        Name="小刘",
                    }
                },
                new Article
                {
                    Id=16,
                    Title=@"高阶：泛型 / 集合 / Lambda / 异常 / IO / 多线程",
                    Body=@"泛型可以有泛型方法/类等，同C#可以有约束public class 
                    Student<T extends IMajor> extends Person {子类继承时：
                    public class OnlineStudent<T extends IMajor> extends 
                    Student<T > {协变/逆变通配符：？实现extends：协变（out）super：
                    逆变（in）Optional 类对应NullableOptional<Integer> age =",
                    PublishTime =DateTime.Now,
                    KeyWords= new List<KeyWord>
                    {
                        new KeyWord{Name="Java"},
                        new KeyWord{Name="C#"},
                        new KeyWord{Name="对比"},
                        new KeyWord{Name="高阶语法"}
                    },
                    Author=new User
                    {
                        Id=1,
                        Name="小刘",
                    }
                },
                new Article
                {
                    Id=17,
                    Title=@"异步方法和TPL： async / await / Parallel",
                    Body=@"封装我们要把上面这个Task封装成方法，怎么办？最重要的一点，
                    这个方法要能返回生成的random，后面的代码要用！public static Task
                    <int> getRandom(){return Task<int>.Run(() =>{Thread.Sleep(500)
                    ; //模拟耗时return new Random().Next();});}@想一想@：应该如何调
                    用这个方法？（提示：不要直接getRandom().Result） 假如我们还需要进
                    一步的封装，添加 ",
                    PublishTime =DateTime.Now,
                    KeyWords= new List<KeyWord>
                    {
                        new KeyWord
                        {
                            Name="异步方法"
                        },
                        new KeyWord
                        {
                            Name="async"
                        },
                        new KeyWord
                        {
                            Name="await"
                        },
                        new KeyWord
                        {
                            Name="并发"
                        }
                    },
                    Author=new User
                    {
                        Id=1,
                        Name="小刘",
                    }
                },
                new Article
                {
                    Id=18,
                    Title=@"面向对象：类和对象/封装/继承/多态/抽象接口/枚举/反射/String",
                    Body=@"类和对象 类文件后缀：.java包（namespace）：项目上右键
                    创建package _17bang.CD.Yz;引入（using）import _17bang.YZ.
                    Student;没有partial类访问修饰符：没有关键字internal（不能显式声
                    明，默认即可，package中可见）static：可以由对象调用（只warning不
                    报错)引用类型和值类型其他类成员快捷键生成：alt+shift+s，构造函数
                    间调用：public Student(int age) {this();}没有属性，只有get",
                    PublishTime =DateTime.Now,
                    KeyWords= new List<KeyWord>
                    {
                        new KeyWord
                        {
                            Name="源栈培训"
                        },
                        new KeyWord
                        {
                            Name="C#"
                        },
                        new KeyWord
                        {
                            Name="语法"
                        },
                        new KeyWord
                        {
                            Name="类"
                        },
                        new KeyWord
                        {
                            Name="对象"
                        }
                    },
                    Author=new User
                    {
                        Id=1,
                        Name="小刘",
                    }
                },
                new Article
                {
                    Id=19,
                    Title=@"C#-面向对象：string还是StringBuilder？",
                    Body=@"我们之前故意对string一带而过，是因为它非常特别。首先，它是
                    imutable（不可变的）即一个string定义的字符串，一旦设定，就不能改
                    变。在string上直接F12转到定义，就可以看到String类的成员。其中，只
                    有一个只读的静态成员Empty（建议使用，以替代null和空字符串""）：
                    public static readonly String Empty;一个只读的索引器，可以获取
                    字符串中某个下标的字符：public char this[int index] { get; }
                    一个只读的属性Len",
                    PublishTime =DateTime.Now,
                    KeyWords= new List<KeyWord>
                    {
                        new KeyWord
                        {
                            Name="源栈培训"
                        },
                        new KeyWord
                        {
                            Name="C#"
                        },
                        new KeyWord
                        {
                            Name="语法"
                        },
                        new KeyWord
                        {
                            Name="类"
                        },
                        new KeyWord
                        {
                            Name="对象"
                        }
                    },
                    Author=new User
                    {
                        Id=1,
                        Name="小刘",
                    }
                },
                new Article
                {
                    Id=20,
                    Title=@"C#-面向对象：争议TDD（测试驱动开发）",
                    Body=@"在谈到特性的使用场景时，还有一个绝对离不开的就是单元测试按
                    飞哥的定义，单元测试是开发人员自己用代码实现的测试。注意这个定义，
                    其核心在于：主体是“开发人员”，不是测试人员。途径是“通过代码实现”，
                    不是通过手工测试。实质是一种“测试”，不是代码调试。暂时还有点抽象，
                    同学们记着这个概念，我们先用一个NUnit项目来看一看单元测试长个什么
                    样。在solution上右键添加项目，选择Test中的NUnit Test Project，
                    输入项目名称，点击OK：Visual Studio直接集成了NUnit说明微软在开源和",
                    PublishTime =DateTime.Now,
                    KeyWords= new List<KeyWord>
                    {
                        new KeyWord
                        {
                            Name="源栈培训"
                        },
                        new KeyWord
                        {
                            Name="C#"
                        },
                        new KeyWord
                        {
                            Name="语法"
                        },
                        new KeyWord
                        {
                            Name="类"
                        },
                        new KeyWord
                        {
                            Name="对象"
                        }
                    },
                    Author=new User
                    {
                        Id=1,
                        Name="小刘",
                    }
                },
                new Article
                {
                    Id=21,
                    Title=@"C#-面向对象：争议TDD（测试驱动开发）",
                    Body=@"在谈到特性的使用场景时，还有一个绝对离不开的就是单元测试按
                    飞哥的定义，单元测试是开发人员自己用代码实现的测试。注意这个定义，
                    其核心在于：主体是“开发人员”，不是测试人员。途径是“通过代码实现”，
                    不是通过手工测试。实质是一种“测试”，不是代码调试。暂时还有点抽象，
                    同学们记着这个概念，我们先用一个NUnit项目来看一看单元测试长个什么
                    样。在solution上右键添加项目，选择Test中的NUnit Test Project，
                    输入项目名称，点击OK：Visual Studio直接集成了NUnit说明微软在开源和",
                    PublishTime =DateTime.Now,
                    KeyWords= new List<KeyWord>
                    {
                        new KeyWord
                        {
                            Name="源栈培训"
                        },
                        new KeyWord
                        {
                            Name="C#"
                        },
                        new KeyWord
                        {
                            Name="语法"
                        },
                        new KeyWord
                        {
                            Name="类"
                        },
                        new KeyWord
                        {
                            Name="对象"
                        }
                    },
                    Author=new User
                    {
                        Id=1,
                        Name="小刘",
                    }
                },
                new Article
                {
                    Id=22,
                    Title=@"C#-面向对象：争议TDD（测试驱动开发）",
                    Body=@"在谈到特性的使用场景时，还有一个绝对离不开的就是单元测试按
                    飞哥的定义，单元测试是开发人员自己用代码实现的测试。注意这个定义，
                    其核心在于：主体是“开发人员”，不是测试人员。途径是“通过代码实现”，
                    不是通过手工测试。实质是一种“测试”，不是代码调试。暂时还有点抽象，
                    同学们记着这个概念，我们先用一个NUnit项目来看一看单元测试长个什么
                    样。在solution上右键添加项目，选择Test中的NUnit Test Project，
                    输入项目名称，点击OK：Visual Studio直接集成了NUnit说明微软在开源和",
                    PublishTime =DateTime.Now,
                    KeyWords= new List<KeyWord>
                    {
                        new KeyWord
                        {
                            Name="源栈培训"
                        },
                        new KeyWord
                        {
                            Name="C#"
                        },
                        new KeyWord
                        {
                            Name="语法"
                        },
                        new KeyWord
                        {
                            Name="类"
                        },
                        new KeyWord
                        {
                            Name="对象"
                        }
                    },
                    Author=new User
                    {
                        Id=1,
                        Name="小刘",
                    }
                },
            };
        }

        internal IList<Article> Get(int pageIndex, int pageSize)
        {
            return articles
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }
        public int ArticleCount()
        {
            return articles.Count;
        }
        void Delete()
        { }
        void Save(Article article)
        {
            articles.Add(article);
        }
    }

}
