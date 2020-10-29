using System;
using System.Collections.Generic;
using System.Text;

namespace CSharplearn
{
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
