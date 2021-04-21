using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace NewCsharplearn
{
    //泛型改造双向链表
    public class DoubleLinked<T> : IEnumerable<DoubleLinked<T>>
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
        private DoubleLinked<T> getHead()
        {
            DoubleLinked<T> head = this;
            if (head.Previous != null)
            {
                head = head.Previous;
            }
            return head;
        }

        public IEnumerator<DoubleLinked<T>> GetEnumerator()
        {
            return new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        struct Enumerator : IEnumerator<DoubleLinked<T>>
        {
            private DoubleLinked<T> _current;
            private bool end;
            private DoubleLinked<T> _head;
            public object Current => _current.Previous;
            DoubleLinked<T> IEnumerator<DoubleLinked<T>>.Current => _current.Previous;
            public Enumerator(DoubleLinked<T> node)
            {
                _current = node;
                end = false;
                _head = _current.getHead();
            }

            public void Dispose()
            {
                return;
            }

            public bool MoveNext()
            {
                if (end)
                {
                    return false;
                }//else
                if (_current.Next == null)
                {
                    _current.Next = new DoubleLinked<T>
                    {
                        Previous = _current
                    };
                    end = true;
                }//else
                _current = _current.Next;

                return true;
            }
            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
    }
    public static class DoubleLinkedExtesion
    {
        public static DoubleLinked<string> GetMax(this DoubleLinked<string> node)
        {
            DoubleLinked<string> max = null;

            foreach (var item in node)
            {
                if (item.Value > max.Value)
                {
                    max = item;
                }
            }
            return max;
        }
    }
}
