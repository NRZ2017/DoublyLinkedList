using System;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>();

            doublyLinkedList.AddAt(0, 1);
            doublyLinkedList.AddAt(0, 23);
            doublyLinkedList.AddAt(1, 33);
            doublyLinkedList.AddFirst(99);
            doublyLinkedList.AddLast(100);
            doublyLinkedList.RemoveAt(2);
            doublyLinkedList.RemoveFront();
            doublyLinkedList.RemoveEnd();
        }
    }
}
 