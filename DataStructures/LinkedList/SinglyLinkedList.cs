using DataStructures.LinkedList.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{
    // The purpose of this assignment is to create a custom linked list data structure.
    public class SinglyLinkedList<T> : ILinkedList<T?>
    {
        private Node<T>? _head;
        private int _count;

        public int Count => _count;
        public bool IsReadOnly => false;


        // Time Complexity : O(1)
        public void AddToFront(T? item)
        {
            var newHead = new Node<T>(item)
            {
                Next = _head
            };

            _head = newHead;
            ++_count;
        }

        public void AddToEnd(T? item)
        {
            var newNode = new Node<T>(item);
            if (_head is null)
            {
                _head = newNode;
            }
            else
            {
                var tail = GetNodes().Last();
                tail.Next = newNode;        // Add it as tail's next node
            }
            ++_count;
        }

        public void Add(T? item)
        {
            AddToEnd(item);
        }

        public void Clear()
        {
            Node<T>? current = _head;

            // This loop is not really needed
            //If node is a private class in SinglyLinkedList class
            while (current is not null)
            {
                Node<T>? temporary = current;
                current = current.Next;
                temporary.Next = null;
            }
            _head = null;
            _count = 0;
        }

        public bool Contains(T? item)
        {
            if (item is null)
            {
                return GetNodes().Any(node => node.Value is null);
            }

            return GetNodes().Any(node => item.Equals(node.Value));
        }

        public void CopyTo(T?[] array, int arrayIndex)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (arrayIndex < 0 || arrayIndex >= array.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(arrayIndex));
            }

            if (array.Length < _count + arrayIndex)
            {
                throw new ArgumentException("Array is not long enough ");
            }

            foreach (var node in GetNodes())
            {
                array[arrayIndex] = node.Value;
                ++arrayIndex;
            }
        }

        // Removes the first occurence of that item and returns a boolean
        public bool Remove(T? item)
        {
            Node<T>? predecessor = null;
            foreach (var node in GetNodes())
            {
                if ((node.Value is null && item is null) ||
                    (node.Value is not null && node.Value.Equals(item)))
                {
                    if (predecessor is null)    // means if the node to be removed was head
                    {
                        _head = node.Next;
                    }
                    else
                    {
                        predecessor.Next = node.Next;   // simple point to the next node of the current (to be removed) node
                    }
                    --_count;
                    return true;
                }
                predecessor = node;
            }
            return false;   // Indicates item was not found
        }

        public IEnumerator<T?> GetEnumerator()
        {
            foreach (var node in GetNodes())
            {
                yield return node.Value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private IEnumerable<Node<T>> GetNodes()
        {
            Node<T>? current = _head;

            while (current is not null)
            {
                yield return current;
                current = current.Next;
            }

        }
    }
}
