using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{
    public class Node<T>
    {
        public T? Value { get; }
        public Node<T> Next { get; set; }

        public Node(T? value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return $"Value: {Value} " + $"Next {(Next is null ? "null" : Next.Value)}";
        }
    }
}
