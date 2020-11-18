using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpLearn
{
    public interface ISendMessage
    {
        void Send(User receiver);
    }
}
