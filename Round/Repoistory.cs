using System;
using System.Collections.Generic;
using System.Text;

namespace SELFstudy
{
    //定义一个仓库（Repoistory）类，用于存取对象，其中包含：
    //一个int类型的常量version一个静态只读的字符串connection，以后可用于连接数据库
    public class Repoistory
    {
        const int version = 1;
        static readonly string connection;
    }
}
