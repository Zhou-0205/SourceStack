using System;
using System.Collections.Generic;
using System.Text;

namespace NewCsharplearn
{
    //泛型改造双向链表
    public class DoubleLinked<T>
    {
        public DoubleLinked<T> Previous { get; set; }
        public DoubleLinked<T> Next { get; set; }
        public int Value { get; set; }
        public void InsertAfter(DoubleLinked<T> node)
        {
            if (this.Next == null)
            {

            }
            else
            {
                this.Next.Previous = node;
                node.Next = this.Next;
            }
            this.Next = node;
            node.Previous = this;
        }
        public void InsertBefore(DoubleLinked<T> node)
        {
            if (this.Previous == null)
            {

            }
            else
            {
                this.Previous.Next = node;
                node.Previous = this.Previous;
            }
            this.Previous = node;
            node.Next = this;
        }
        public void Delete()
        {
            if (this.Previous == null)
            {
                this.Next.Previous = null;
                this.Next = null;
            }
            else if (this.Next == null)
            {
                this.Previous.Next = null;
                this.Previous = null;
            }
            else
            {
                this.Next.Previous = this.Previous;
                this.Previous.Next = this.Next;
                this.Next = null;
                this.Previous = null;
            }
        }
        public void Swap(DoubleLinked<T> node)
        {
            DoubleLinked<T> preThis = this.Previous;
            DoubleLinked<T> nextThis = this.Next;
            if (node.Next != this)
            {
                this.Delete();
                node.InsertAfter(this);
            }//else
            if (nextThis == node)
            {
                nextThis = this;
            }//else
            if (preThis == node)
            {
                preThis = this;
            }//else
            if (preThis == null)
            {
                if (node.Next != nextThis)
                {
                    node.Delete();
                    nextThis.InsertBefore(node);
                }//else
            }
            else
            {
                if (node.Previous != preThis)
                {
                    node.Delete();
                    preThis.InsertAfter(node);
                }//else
            }
        }
    }
}
