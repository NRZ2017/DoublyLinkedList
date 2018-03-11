using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedList
{
    class DoublyLinkedList<T> where T : IComparable<T>
    {
        public DoublyLinkedListNode<T> Head;
        public DoublyLinkedListNode<T> Tail;
        bool IsEmpty;

        public DoublyLinkedList()
        {
        }

        public void AddLast(T value)
        {
            if (Head == null)
            {
                Head = new DoublyLinkedListNode<T>(value);
            }

            else
            {
                DoublyLinkedListNode<T> tempNode = Head;
                while (tempNode != null)
                {
                    if (tempNode.Next == null)
                    {
                        // Create a new item at 
                        tempNode.Next = new DoublyLinkedListNode<T>(value);
                        return;
                    }
                    tempNode = tempNode.Next;
                }

            }
        }

        public void AddFirst(T value)
        {
            if (Head == null)
            {
                Head = new DoublyLinkedListNode<T>(value);
            }
            else
            {
                DoublyLinkedListNode<T> tempNode = new DoublyLinkedListNode<T>(value);
                tempNode.Next = Head;
                Head = tempNode;
            }
        }


        public bool RemoveAt(int index)
        {
            if (IsEmpty)
            {
                return false;
            }

            else
            {
                DoublyLinkedListNode<T> tempnode = Head;
                DoublyLinkedListNode<T> prevnode = null;
                for (int i = 0; i < index; i++)
                {
                    prevnode = tempnode;
                    tempnode = tempnode.Next;
                }
                prevnode.Next = tempnode.Next;
            }
            return true;
        }

        public void AddAt(int position, T value)
        {
            DoublyLinkedListNode<T> tempnode = Head;
            DoublyLinkedListNode<T> prevnode = null;

            if (IsEmpty)
            {
                tempnode = Head;
            }

            else
            {
                for(int i = 0; i < position; i++)
                {
                        tempnode = tempnode.Next;
                }
                    
            }

        }
    }
}
