using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
    //为之前所有类（含User、HelpMoney等）抽象一个基类：Entity，包含一个只读的Id属性
    public class Entity
    {
        public int id
        {
            get;
        }
    }
}
