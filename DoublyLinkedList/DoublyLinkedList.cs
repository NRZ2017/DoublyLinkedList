using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedList
{
    class DoublyLinkedList<T> where T : IComparable<T>
    {
        public DoublyLinkedListNode<T> Head;
        public DoublyLinkedListNode<T> Tail;

        public DoublyLinkedList()
        {
            Head = null;
            Tail = null;
        }

        public void AddLast(T value)
        {
            if (Head == null)
            {
                Head = new DoublyLinkedListNode<T>(value);
                Tail = Head;
            }

            else
            {
                DoublyLinkedListNode<T> tempNode = Head;
               
                    Tail.Next = new DoublyLinkedListNode<T>(value);
                Tail.Next.Previous = Tail;
                Tail.Next = Tail;

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
            if (Head == null)
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
                if(tempnode.Next == null)
                {
                    Tail = prevnode.Next;
                }
            }
            return true;
        }

        public bool RemoveFront()
        {
            if (Head == null)
            {
                return false;
            }

            else
            {
                Head = Head.Next;
                Head.Previous = null;
            }
            return true;
        }

        public bool RemoveEnd()
        {
            if (Head == null)
            {
                return false;
            }
            else
            {
               Tail.Previous.Next = null;
               Tail = Tail.Previous;
            }
            return true;
        }

        public void AddAt(int position, T value)
        {
            DoublyLinkedListNode<T> tempnode = Head;

            if (Head == null)
            {
                Head = new DoublyLinkedListNode<T>(value);
            }
            else
            {
                for (int i = 0; i < position; i++)
                {
                    tempnode = tempnode.Next;
                    if (tempnode == null)
                    {
                        throw new IndexOutOfRangeException();
                    }
                }

                DoublyLinkedListNode<T> newnode = new DoublyLinkedListNode<T>(value);
                if (tempnode.Previous != null)
                {
                    newnode.Previous = tempnode.Previous;
                    tempnode.Previous.Next = newnode;
                }
                else
                {
                    Head = newnode;
                }
                tempnode.Previous = newnode;
                newnode.Next = tempnode;
            }

        }

        public override string ToString()
        {
            string output = "";
            var node = Head;
            while (node != null)
            {
                output += node.Data.ToString() + ", ";
                node = node.Next;
            }

            return output.Length > 0 ? output.Substring(0, output.Length - 2) : output;
        }
    }
}
