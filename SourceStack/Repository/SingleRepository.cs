using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SourceStack.Entities;
using SourceStack.Repository;

public class SingleRepository
{
    private static IList<Article> articles;
    public SingleRepository()
    {
        UserRepository userRepository = new UserRepository();
        articles = new List<Article>
            {
                new Article
                {
                    Id=1,
                    Title=@"高阶：泛型 / 集合 / Lambda / 异常 / IO / 多线程",
                    Body=@" 泛型
                    可以有泛型方法/类等，同C#
                    可以有约束
                    public class Student<T extends IMajor> extends Person {
                    子类继承时：
                    public class OnlineStudent<T extends IMajor> extends Student<T > {
                    协变/逆变
                    通配符：？实现
                        extends：协变（out）
                        super：逆变（in）
                    Optional 类
                    对应Nullable
		                 Optional<Integer> age = Optional.of(32);
		                 int a = age.get();
                    集合
                    都是Iterable<T> （类似于IEnumerable<T>）的子类，实现它即可 foreach 迭代，其下
                    Collection是最基本的集合接口：有容量，可以增删改查
                    再其下是List，是一个（索引）有序的 Collection
                    接口：是代表集合的抽象数据类型。例如 Collection、、Set、Map 等
                    实现（类）：、LinkedList、、
                     接口和类。Map 里存储的是键/值对。
                    ",
                    PublishTime =DateTime.Now,
                    KeyWords= new List<KeyWord>
                    {
                        new KeyWord{Name="Java"},
                        new KeyWord{Name="C#"},
                        new KeyWord{Name="对比"},
                        new KeyWord{Name="高阶语法"}
                    },
                    Author=userRepository.Find(1)
                },
                new Article
                {
                    Id=2,
                    Title=@"异步方法和TPL： async / await / Parallel",
                    Body=@" 泛型
                    可以有泛型方法/类等，同C#
                    可以有约束
                    public class Student<T extends IMajor> extends Person {
                    子类继承时：
                    public class OnlineStudent<T extends IMajor> extends Student<T > {
                    协变/逆变
                    通配符：？实现
                        extends：协变（out）
                        super：逆变（in）
                    Optional 类
                    对应Nullable
		                 Optional<Integer> age = Optional.of(32);
		                 int a = age.get();
                    集合
                    都是Iterable<T> （类似于IEnumerable<T>）的子类，实现它即可 foreach 迭代，其下
                    Collection是最基本的集合接口：有容量，可以增删改查
                    再其下是List，是一个（索引）有序的 Collection
                    接口：是代表集合的抽象数据类型。例如 Collection、、Set、Map 等
                    实现（类）：、LinkedList、、
                     接口和类。Map 里存储的是键/值对。
                    ",
                    PublishTime =DateTime.Now,
                    KeyWords= new List<KeyWord>
                    {
                        new KeyWord{Name="Java"},
                        new KeyWord{Name="C#"},
                        new KeyWord{Name="对比"},
                        new KeyWord{Name="高阶语法"}
                    },
                    Author=userRepository.Find(2)
                },
                new Article
                {
                    Id=3,
                    Title=@"面向对象：类和对象/封装/继承/多态/抽象接口/枚举/反射/String",
                    Body=@" 泛型
                    可以有泛型方法/类等，同C#
                    可以有约束
                    public class Student<T extends IMajor> extends Person {
                    子类继承时：
                    public class OnlineStudent<T extends IMajor> extends Student<T > {
                    协变/逆变
                    通配符：？实现
                        extends：协变（out）
                        super：逆变（in）
                    Optional 类
                    对应Nullable
		                 Optional<Integer> age = Optional.of(32);
		                 int a = age.get();
                    集合
                    都是Iterable<T> （类似于IEnumerable<T>）的子类，实现它即可 foreach 迭代，其下
                    Collection是最基本的集合接口：有容量，可以增删改查
                    再其下是List，是一个（索引）有序的 Collection
                    接口：是代表集合的抽象数据类型。例如 Collection、、Set、Map 等
                    实现（类）：、LinkedList、、
                     接口和类。Map 里存储的是键/值对。
                    ",
                    PublishTime =DateTime.Now,
                    KeyWords= new List<KeyWord>
                    {
                        new KeyWord{Name="Java"},
                        new KeyWord{Name="C#"},
                        new KeyWord{Name="对比"},
                        new KeyWord{Name="高阶语法"}
                    },
                    Author=userRepository.Find(3)
                },
                new Article
                {
                    Id=4,
                    Title=@"C#-面向对象：string还是StringBuilder？",
                    Body=@" 泛型
                    可以有泛型方法/类等，同C#
                    可以有约束
                    public class Student<T extends IMajor> extends Person {
                    子类继承时：
                    public class OnlineStudent<T extends IMajor> extends Student<T > {
                    协变/逆变
                    通配符：？实现
                        extends：协变（out）
                        super：逆变（in）
                    Optional 类
                    对应Nullable
		                 Optional<Integer> age = Optional.of(32);
		                 int a = age.get();
                    集合
                    都是Iterable<T> （类似于IEnumerable<T>）的子类，实现它即可 foreach 迭代，其下
                    Collection是最基本的集合接口：有容量，可以增删改查
                    再其下是List，是一个（索引）有序的 Collection
                    接口：是代表集合的抽象数据类型。例如 Collection、、Set、Map 等
                    实现（类）：、LinkedList、、
                     接口和类。Map 里存储的是键/值对。
                    ",
                    PublishTime =DateTime.Now,
                    KeyWords= new List<KeyWord>
                    {
                        new KeyWord{Name="Java"},
                        new KeyWord{Name="C#"},
                        new KeyWord{Name="对比"},
                        new KeyWord{Name="高阶语法"}
                    },
                    Author=userRepository.Find(4)
                },
                new Article
                {
                    Id=5,
                    Title=@"C#-面向对象：争议TDD（测试驱动开发）",
                    Body=@" 泛型
                    可以有泛型方法/类等，同C#
                    可以有约束
                    public class Student<T extends IMajor> extends Person {
                    子类继承时：
                    public class OnlineStudent<T extends IMajor> extends Student<T > {
                    协变/逆变
                    通配符：？实现
                        extends：协变（out）
                        super：逆变（in）
                    Optional 类
                    对应Nullable
		                 Optional<Integer> age = Optional.of(32);
		                 int a = age.get();
                    集合
                    都是Iterable<T> （类似于IEnumerable<T>）的子类，实现它即可 foreach 迭代，其下
                    Collection是最基本的集合接口：有容量，可以增删改查
                    再其下是List，是一个（索引）有序的 Collection
                    接口：是代表集合的抽象数据类型。例如 Collection、、Set、Map 等
                    实现（类）：、LinkedList、、
                     接口和类。Map 里存储的是键/值对。
                    ",
                    PublishTime =DateTime.Now,
                    KeyWords= new List<KeyWord>
                    {
                        new KeyWord{Name="Java"},
                        new KeyWord{Name="C#"},
                        new KeyWord{Name="对比"},
                        new KeyWord{Name="高阶语法"}
                    },
                    Author=userRepository.Find(5)
                }

            };
    }
    public Article Find(int id)
    {
        return articles.Where(a => a.Id == id).SingleOrDefault();
    }
}

