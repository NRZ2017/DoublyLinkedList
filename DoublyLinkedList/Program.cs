using System;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>();

            doublyLinkedList.AddAt(1, 1);
            doublyLinkedList.AddAt(2, 23);
            doublyLinkedList.AddAt(1, 33);
            
        }
    }
}
 