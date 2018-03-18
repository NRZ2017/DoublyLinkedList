using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedList
{
    class DoublyLinkedListNode<T> where T : IComparable<T>
    {
        public T Data;
        public DoublyLinkedListNode<T> Next;

        public DoublyLinkedListNode<T> Previous;

        public DoublyLinkedListNode(T data)
        {
            Data = data;
        }
    }
}
