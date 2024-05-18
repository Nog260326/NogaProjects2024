using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    class LinkedList : IEnumerable<int>
    {
        public Node Head { get; set; } 
        public Node Last { get; set; }
       
        public LinkedList(int value)
        {
            Head = new Node(value, null);
            Last = Head;
        }

        public void Append(int add_last)
        {
            Node new_last = new Node(add_last, null);
            Last.Next = new_last;
            Last = new_last;
        }
        public void Prepend(int add_first)
        {
            Node old_head = Head;
            Node new_head = new Node(add_first, old_head);
            Head = new_head;
        }
        public int Pop()
        {
            Node prev = Head;
            Node pos = Head.Next;
            int poped_value = 0;
            while(pos != null)
            {
                if(pos.Next == null)
                {
                    poped_value = pos.Value;
                    prev.Next = null;
                    Last = prev;
                    break;
                }
                pos = pos.Next;
                prev = prev.Next;
            }
            return poped_value;
        }
        public int Unqueue()
        {
            Node del = Head;
            int val = del.Value;
            Head = Head.Next;
            del.Next = null;
            return val;
        }
        public IEnumerable<int> ToList()
        {
            return this;
        }
        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            return (IEnumerator<int>) GetEnumerator();
        }
        public IEnumerator GetEnumerator()
        {
            return new LinkedList_enum(this);
        }

        public bool IsCircular()
        {
            Node pos = Head;
            while(pos.Next != null)
            {
                if(pos.Next == Head)
                {
                    return true;
                }
                pos = pos.Next;
            }
            return false;
        }
        public void Sort()
        {
            if(Head.Next == null)
            {
                return; 
            }
            Node new_list = new Node(0, null);
            int min = 0;
            int max = 0;
            Node pos = Head.Next;
            Node prev = Head;

            while (pos != null)
            {
                if(prev.Value < pos.Value)
                {
                    min = prev.Value;
                    prev.Next = prev.Next.Next;
                    new_list.Value = min;
                }
                else
                {
                    prev = prev.Next;
                    pos = pos.Next;
                }
                
            } 
        }
        public Node GetMaxNode()
        {
            Node pos = Head;
            Node max = Head;
            while (pos.Next != null)
            {
                if(pos.Value > pos.Next.Value)
                {
                    max = pos;
                }
                pos = pos.Next;
            }
            if(max == Head)
            {
                if(max.Value > pos.Value)
                {
                    return max;
                }
            }
            return pos;
        }
        public Node GetMinNode()
        {
            Node pos = Head;
            Node min = Head;
            while (pos.Next != null)
            {
                if (pos.Value < pos.Next.Value)
                {
                    min = pos;
                }
                pos = pos.Next;
            }
            if (min == Head)
            {
                if (min.Value > pos.Value)
                {
                    return min;
                }
            }
            return pos;
        }

        public string ToString()
        {
            string s = "{";
            Node pos = Head;
            while(pos != null)
            {
                s += (pos.Value + ", ");
                pos = pos.Next;
            }
            s += "}";
            return s;
        }

      
    }

    class LinkedList_enum : IEnumerator<int>
    {
        public LinkedList List { get; private set; }
        public Node Pos { get; private set; }

        public LinkedList_enum(LinkedList l)
        {
            List = l;
            Pos = GetBeforeHead();
        }

        object IEnumerator.Current => Current;

        public int Current
        {
            get
            {
                try
                {
                    return Pos.Value;
                }
                catch (NullReferenceException e)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        bool IEnumerator.MoveNext()
        {
            if (Pos != null) {
                Pos = Pos.Next;
            }
            return (Pos != null);
        }

        void IEnumerator.Reset()
        {
            Pos = GetBeforeHead();
        }

        public void Dispose()
        {
        }

        public Node GetBeforeHead()
        {
            Node before_head = new Node(0, List.Head);
            return before_head;
        }
    }
}
