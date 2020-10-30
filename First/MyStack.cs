using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
    //自己实现一个模拟栈（MimicStack）类，入栈出栈数据均为int类型，包含如下功能：

    //    出栈Pop()，弹出栈顶数据入栈Push()，可以一次性压入多个数据出/入栈检查，
    //    如果压入的数据已超过栈的深度（最大容量），提示“栈溢出”如果已弹出所有数据，提示“栈已空”
    public class MyStack
    {
        private int maxSize;

        public int MaxSize
        {
            get { return maxSize; }
            set { maxSize = value; }
        }
        public int[] data;
        private int top; 

        public int Top
        {
            get { return top; }
        }
        
        public MyStack(int size)
        {
            data = new int[size];
            maxSize = size;
            top = -1;
        }
        
        public int this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }
        
        public int GetLength()
        {
            return top + 1;
        }

        public bool IsEmpty()
        {
            if (-1 == top)
            {
                return true;
            }
            return false;
        }
        public bool IsFull()
        {
            if (top == maxSize - 1)
            {
                return true;
            }
            return false;
        }
        public void Push(int item)
        {
            if (IsFull())
            {
                Console.WriteLine("栈已满，无法压入");
                return;
            }
            data[++top] = item;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("栈已空，无法弹出");
                return default(int);
            }
            return data[top--];
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("栈为空，无法弹出");
                return default(int);
            }
            return data[top];
        }
    }
}
