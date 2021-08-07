//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructures
//{
//    class DoubleNode
//    {
//        public int data;
//        public DoubleNode previous;
//        public DoubleNode next;
//        public DoubleNode(int value)
//        {
//            data = value;
//            next = null;
//            previous = null;
//        }
//    }
//    class DoublyLinkedList
//    {
//        DoubleNode node;

//        public DoublyLinkedList InsertAtBeginning(DoublyLinkedList doubleList, int value)
//        {
//            DoubleNode newNode = new DoubleNode(value);
//            newNode.previous = null;
//            newNode.next = doubleList.node;
//            if (doubleList.node != null)
//                doubleList.node.previous = newNode;
//            doubleList.node = newNode;
//            return doubleList;
//        }
//        public DoublyLinkedList InsertAtEnd(DoublyLinkedList doubleList, int value)
//        {
//            DoubleNode newNode = new DoubleNode(value);
//            newNode.next = null;
//            DoubleNode lastNode = getLastNode(doubleList);
//            newNode.previous = lastNode;
//            lastNode.next = newNode;
//            return doubleList;
//        }
//        public DoublyLinkedList InsertAt(DoublyLinkedList doubleList, int value, int position)
//        {
//            DoubleNode newNode = new DoubleNode(value);
//            DoubleNode previousNode = getPreviousNode(doubleList, position);
//            previousNode.next.previous = newNode;
//            newNode.previous = previousNode;
//            newNode.next = previousNode.next;
//            previousNode.next = newNode;
//            return doubleList;
//        }
//        public DoublyLinkedList DeleteAtBeginning(DoublyLinkedList doubleList)
//        {
//            doubleList.node = doubleList.node.next;
//            doubleList.node.previous = null;
//            return doubleList;
//        }
//        public DoublyLinkedList DeleteAtEnd(DoublyLinkedList doubleList)
//        {

//            DoubleNode lastNode = getLastNode(doubleList);
//            lastNode.previous.next = null;
//            return doubleList;
//        }
//        public DoublyLinkedList DeleteAt(DoublyLinkedList doubleList, int position)
//        {
//            DoubleNode previousNode = getNodeAt(doubleList, position - 1);
//            previousNode.next = previousNode.next.next;
//            previousNode.next.previous = previousNode;
//            return doubleList;
//        }
//        public void Traverse(DoublyLinkedList doubleList)
//        {
//            while (doubleList.node != null)
//            {
//                Console.WriteLine(doubleList.node.data);
//                doubleList.node = doubleList.node.next;
//            }
//        }
//        private DoubleNode getLastNode(DoublyLinkedList doubleList)
//        {
//            DoubleNode lastNode = doubleList.node;
//            while (lastNode.next != null)
//            {
//                lastNode = lastNode.next;
//            }
//            return lastNode;
//        }
//        private DoubleNode getPreviousNode(DoublyLinkedList doubleList, int position)
//        {
//            DoubleNode previousNode = doubleList.node;
//            int i = 1;
//            while (previousNode.next != null && i < position - 1)
//            {
//                previousNode = previousNode.next;
//                i++;
//            }
//            return previousNode;

//        }
//        private DoubleNode getNodeAt(DoublyLinkedList doubleList, int position)
//        {
//            DoubleNode positionNode = doubleList.node;
//            int i = 1;
//            while (positionNode.next != null && i <= position-1)
//            {
//                positionNode = positionNode.next;
//                i++;
//            }
//            return positionNode;
//        }
//        class Doubly
//        {
//            //static void Main(string[] args)
//            //{
//            //    DoublyLinkedList doubleList = new DoublyLinkedList();
//            //    doubleList.InsertAtBeginning(doubleList, 4);
//            //    doubleList.InsertAtBeginning(doubleList, 3);
//            //    doubleList.InsertAtEnd(doubleList, 6);
//            //    doubleList.InsertAtEnd(doubleList, 7);
//            //    doubleList.InsertAt(doubleList, 5, 3);
//            //    doubleList.DeleteAtBeginning(doubleList);
//            //    doubleList.DeleteAtEnd(doubleList);
//            //    doubleList.DeleteAt(doubleList, 2);
//            //    doubleList.Traverse(doubleList);

//            //    Console.Read();
//            //}
//        }
//    }
//}
