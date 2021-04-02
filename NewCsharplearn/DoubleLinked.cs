using System;
using System.Collections.Generic;
using System.Text;

namespace NewCsharplearn
{
    public class DoubleLinked
    {
        public DoubleLinked Previous { get; set; }
        public DoubleLinked Next { get; set; }
        public int Value { get; set; }
        public void InsertAfter(DoubleLinked node)
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
        public void InsertBefore(DoubleLinked node)
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
        public void Swap(DoubleLinked node)
        {
            DoubleLinked preThis = this.Previous;
            DoubleLinked nextThis = this.Next;
            if (node.Next != this)
            {
                this.Delete();
                node.InsertAfter(this);
            }
            if (nextThis==node)
            {
                nextThis = this;
            }
            if (preThis == node)
            {
                preThis = this;
            }
            if (preThis == null)
            {
                if (node.Next != nextThis)
                {
                    node.Delete();
                    nextThis.InsertBefore(node);
                }
            }
            else
            {
                if (node.Previous != preThis)
                {
                    node.Delete();
                    preThis.InsertAfter(node);
                }
            }
        }
    }
}
