using DataStructures.LinkedList.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{
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
                tail.Next = newNode;
            }
            _count++;
        }

        public void Add(T? item)
        {
            AddToEnd(item);
        }

        public void Clear()
        {
            Node<T>? current = _head;

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
            throw new NotImplementedException();
        }

        public void CopyTo(T?[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T? item)
        {
            throw new NotImplementedException();
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
            if (_head is null)
            {
                yield break;
            }

            Node<T>? current = _head;

            while (current is not null)
            {
                yield return current;
                current = current.Next;
            }

        }
    }
}
