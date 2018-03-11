using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedList
{
    class DoublyLinkedListNode<T> where T : IComparable<T>
    {
        public T data;
        public DoublyLinkedListNode<T> Next;

        public DoublyLinkedListNode<T> Previous;

        public DoublyLinkedListNode(T Data)
        {
            Data = data;
        }
    }
}
