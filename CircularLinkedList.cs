//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructures
//{
//    public class CircularNode 
//    {
//        public int data;
//        public CircularNode next;
//        public CircularNode(int value)
//        {
//            data = value;
//            next = null;
//        }
//    }
//    public class CircularLinkedList
//    {
//        CircularNode node;

//        //Operations
//        public CircularLinkedList InsertEmpty(CircularLinkedList circleList,int value) 
//        {
//            CircularNode newNode = new CircularNode(value);
//            newNode.next = newNode;
//            circleList.node = newNode;
//            return circleList;
//        }
//        public CircularLinkedList InsertAtBeginning(CircularLinkedList circleList, int value)
//        {
//            CircularNode newNode = new CircularNode(value);
//            CircularNode lastNode = getLastNode(circleList);
//            newNode.next = circleList.node;
//            lastNode.next = newNode;
//            circleList.node = newNode;
//            return circleList;
//        }
//        public CircularLinkedList InsertAtEnd(CircularLinkedList circleList, int value) 
//        {
//            CircularNode newNode = new CircularNode(value);
//            CircularNode lastNode = getLastNode(circleList);
//            newNode.next = circleList.node;
//            lastNode.next = newNode;
//            return circleList;
//        }
//        public CircularLinkedList InsertAt(CircularLinkedList circleList, int value,int position)
//        {
//            CircularNode newNode = new CircularNode(value);
            
//            CircularNode positionNode = getNodeAt(circleList,position-1);
//            newNode.next = positionNode.next;
//            positionNode.next = newNode;
//            return circleList;
//        }
//        public CircularLinkedList DeleteAtBeginning(CircularLinkedList circleList)
//        {
            
//            CircularNode pointerNode = circleList.node;
//            while (pointerNode.next != circleList.node)
//            {
//                pointerNode = pointerNode.next;
//            }
//            pointerNode.next = circleList.node.next;
//            circleList.node = pointerNode.next;
//            return circleList;
//        }
//        public CircularLinkedList DeleteAtEnd(CircularLinkedList circleList)
//        {

//            CircularNode pointerNode = circleList.node;
//            CircularNode secondPointerNode = pointerNode.next;
//            while (secondPointerNode.next != circleList.node)
//            {
//                pointerNode = pointerNode.next;
//                secondPointerNode = secondPointerNode.next;
//            }
//            pointerNode.next = circleList.node;

//            return circleList;
//        }
//        public CircularLinkedList DeleteAt(CircularLinkedList circleList, int position)
//        {
//            int count = 1;
//            CircularNode pointerNode = circleList.node;
//            CircularNode secondPointerNode = pointerNode.next;
//            while (secondPointerNode.next != circleList.node && count < position-1)
//            {
//                pointerNode = pointerNode.next;
//                secondPointerNode = secondPointerNode.next;
//                count++;
//            }
//            pointerNode.next = secondPointerNode.next;
//            return circleList;
//        }
//            private CircularNode getLastNode(CircularLinkedList circleList)
//        {
//            CircularNode pointerNode = circleList.node;
//            CircularNode firstNode = circleList.node;
//            CircularNode lastNode = circleList.node;
//            while (pointerNode.next != firstNode)
//            {
//                lastNode = pointerNode.next;
//                pointerNode = pointerNode.next;
//            }
//            return lastNode;
//        }
//        private CircularNode getNodeAt(CircularLinkedList circleList,int position)
//        {
//            int count = 1;
//            CircularNode pointerNode = circleList.node;
//            CircularNode firstNode = circleList.node;
//            CircularNode positionNode = circleList.node;
//            while (count < position)
//            {
//                positionNode = pointerNode.next;
//                pointerNode = pointerNode.next;
//                count++;
//            }
//            return positionNode;
//        }
//        public void Traverse(CircularLinkedList circleList)
//        {
//            CircularNode head = circleList.node;
//            do
//            {
//                Console.WriteLine(head.data);
//                head = head.next;

//            }
//            while (head != circleList.node);


//        }
//    }
//    //class Circular
//    //{
//    //    static void Main(string[] args)
//    //    {
//    //        CircularLinkedList circleList = new CircularLinkedList();
//    //        circleList.InsertEmpty(circleList, 4);
//    //        circleList.InsertAtBeginning(circleList, 3);
//    //        circleList.InsertAtBeginning(circleList, 2);
//    //        circleList.InsertAtBeginning(circleList, 1);
//    //        circleList.InsertAtEnd(circleList, 5);
//    //        circleList.InsertAtEnd(circleList, 6);
//    //        circleList.InsertAtEnd(circleList, 8);
//    //        circleList.InsertAt(circleList, 7, 7);
//    //        circleList.InsertAt(circleList, 9, 9);
//    //        circleList.DeleteAtBeginning(circleList);
//    //        circleList.DeleteAtEnd(circleList);
//    //        circleList.DeleteAt(circleList,2);
//    //        circleList.Traverse(circleList);
//    //        Console.ReadKey();


//    //    }
    
//    //}
//}
