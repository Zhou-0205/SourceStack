using System;
using System.Collections.Generic;
using System.Text;

namespace NewCsharplearn
{
    //添加一个新类ContentService，其中有一个发布（Publish()）方法：

    //如果发布Article，需要消耗一个帮帮币
    //如果发布Problem，需要消耗其设置悬赏数量的帮帮币
    //如果发布Suggest，不需要消耗帮帮币

    public class ContentService
    {
        //在ContentService中捕获异常

        //如果是“参数为空”异常，Console.WriteLine() 输出：内容的作者不能为空，将当前异常封装进新异常的InnerException，再将新异常抛出
        //如果是“”参数越界”异常，Console.WriteLine() 输出：求助的Reward为负数（-XX），不再抛出异常

        //ContentService中无论是否捕获异常，均要Console.WriteLine() 输出：XXXX年XX月XX日 XX点XX分XX秒（当前时间），请求发布内容（Id=XXX） 
        public void Publish(Content content)
        {
            try
            {
                content.Publish();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("内容的作者不能为空");
                throw new Exception("内容的作者不能为空", e);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("求助的Reward为负数");
            }
            finally
            {
                Console.WriteLine(DateTime.Now + "请求发布内容：(id=" + content.Id + ")");
            }

            Console.WriteLine("保存到数据库");
        }
    }
}
