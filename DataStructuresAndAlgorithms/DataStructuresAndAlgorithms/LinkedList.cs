using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    class LinkedList
    {

        private class Node
        {
            public int Data;
            public Node Next;

            public Node(int data)
            {
                this.Data = data; 
            }
        }
        private Node _head;
        private int _size;

        public void AddFront(int data)
        {

            //Create new node
            Node newNode = new Node(data);

            //If head...
            if (_head != null)
            {
                // Set it's next to the current head
                newNode.Next = _head;
            }

            // Set current head to be the new head
            _head = newNode;
            _size++;
        }

        public int GetFirst()
        {
            try
            {
                return _head.Data;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            return 0;

        }

        public int GetLast()
        {
            if (_head == null)
            {
                throw new NullReferenceException();
                return 0;
            }
            Node current = _head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            return current.Data;
        }

        public void AddBack(int data)
        {
            if (_head == null)
            {
                throw new NullReferenceException();
            }
            Node last = new Node(data);
            Node current = _head;
            while (_head.Next != null)
            {
                current = current.Next;
            }
            current.Next = last;
            _size++;
        }

        public int Size()
        {
            return _size;
        }

        public void Clear()
        {
            //Remaining nodes exist but will be picked up by GC
            _head = null;
            return;
        }

        public void DeleteValue(int data)
        {
            if (_head != null)
            {
                if (_head.Data == data)
                {
                    _head = _head.Next == null ?  null : _head.Next;
                }
                else
                {
                    Node current = _head;
                    Node previous = null;
                    while (current.Next != null)
                    {
                        if (current.Data == data)
                        {
                            previous.Next = current.Next;
                            current = null;
                            break;
                        }
                        previous = current;
                        current = current.Next;
                    }
                }
            }
            return;
        }

        //Not as good O(n)
        //public int Size()
        //{
        //    int size = 0;
        //    if (_head != null)
        //    {
        //        Node current = _head;
        //        while (current.Next != null)
        //        {
        //            current = current.Next;
        //            size++;
        //        }
        //    }
        //    return size;
        //}

    }
}
