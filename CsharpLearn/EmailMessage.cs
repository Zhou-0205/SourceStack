using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpLearn
{
    public class EmailMessage : ISendMessage
    {
        public void Send(User receiver)
        {
            Console.WriteLine("发送消息");
        }
    }
}