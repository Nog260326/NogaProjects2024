using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int value, Node next)
        {
            Value = value;
            Next = next;
        }
    }
}
