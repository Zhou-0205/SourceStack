using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpLearn
{
    public interface IChat
    {
        void Send(User receiver);
    }
}
