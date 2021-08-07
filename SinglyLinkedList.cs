//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructures
//{
//    //Define a node 
//    class Node
//    {
//        public int data;
//        public Node next;
//        public Node(int value)
//        {
//            data = value;
//            next = null;
//        }
//    }
//    //Define a Singly linked list with necessary operations and the initial node
//    class SinglyLinkedList
//    {
//        Node node;

//        public SinglyLinkedList InsertBeginning(SinglyLinkedList singleList, int value)
//        {
//            Node newNode = new Node(value);
//            newNode.next = singleList.node;
//            singleList.node = newNode;
//            return singleList;
//        }
//        public SinglyLinkedList InsertEnd(SinglyLinkedList singleList, int value)
//        {
//            Node newNode = new Node(value);
//            if (singleList.node == null)
//                node = newNode;
//            else
//            {
//                Node lastNode = getLastNode(singleList);
//                lastNode.next = newNode;
//            }
//            return singleList;
//        }
//        public SinglyLinkedList InsertAt(SinglyLinkedList singlyList, int value, int position)
//        {
//            Node newNode = new Node(value);
//            Node positionNode = getNodeAt(singlyList, position-1);
//            newNode.next = positionNode.next;
//            positionNode.next = newNode;
            
//            return singlyList;
//        }
//        public SinglyLinkedList DeleteAtBeginning(SinglyLinkedList singleList)
//        {
//            singleList.node = singleList.node.next;
//            return singleList;
//        }
//        public SinglyLinkedList DeleteAtEnd(SinglyLinkedList singleList)
//        {
//            Node previousNode = getPreviousToLastNode(singleList);
//            previousNode.next = null;
//            return singleList;
//        }
//        public SinglyLinkedList DeleteAtPosition(SinglyLinkedList singleList,int position)
//        {
//            Node previousNode = getPreviousNodeAt(singleList,position);
//            Node nextNode = getNodeAt(singleList, position).next;
//            previousNode.next = nextNode;
//            return singleList;
//        }
//        public void Traverse(SinglyLinkedList singleList)
//        {
//            while (singleList.node != null)
//            {
//                Console.WriteLine(singleList.node.data);
//                singleList.node = singleList.node.next;
//            }
//        }
//        private Node getLastNode(SinglyLinkedList singlyList)
//        {
//            Node lastNode = singlyList.node;
//            while (lastNode.next != null)
//            {
//                lastNode = lastNode.next;
//            }
//            return lastNode;
//        }
//        private Node getPreviousToLastNode(SinglyLinkedList singlyList)
//        {
//            Node lastNode = singlyList.node;
//            Node previousNode = singlyList.node;
//            while (lastNode.next != null)
//            {
//                previousNode = lastNode;
//                lastNode = lastNode.next;
                
//            }
//            return previousNode;
//        }
//        private Node getNodeAt(SinglyLinkedList singlyList, int position) {
//            Node positionNode = singlyList.node;
//            int length = 1;
//            while (positionNode.next != null && length <= position-1)
//            {
//                positionNode = positionNode.next;
//                length++;
//            }
//            return positionNode;
//        }
//        private Node getPreviousNodeAt(SinglyLinkedList singlyList, int position)
//        {
//            Node positionNode = singlyList.node;
//            Node previousNode = singlyList.node;
//            int length = 1;
//            while (positionNode.next != null && length <= position - 1)
//            {
//                previousNode = positionNode;
//                positionNode = positionNode.next;
//                length++;
//            }
//            return previousNode;
//        }
//    }
//    class LinkedList
//    {
//        //static void Main(string[] args)
//        //{
//        //    SinglyLinkedList singleListObj = new SinglyLinkedList();
//        //    singleListObj.InsertBeginning(singleListObj, 3);
//        //    singleListObj.InsertBeginning(singleListObj, 2);
//        //    singleListObj.InsertBeginning(singleListObj, 1);
//        //    singleListObj.InsertEnd(singleListObj, 5);
//        //    singleListObj.InsertEnd(singleListObj, 6);
//        //    singleListObj.InsertAt(singleListObj, 4,4);
//        //    singleListObj.DeleteAtBeginning(singleListObj);
//        //    singleListObj.DeleteAtEnd(singleListObj);
//        //    singleListObj.DeleteAtPosition(singleListObj,3);
//        //    singleListObj.Traverse(singleListObj);
//        //    Console.Read();
//        //}
//    }
//}
