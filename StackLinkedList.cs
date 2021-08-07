//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructures
//{
//    public class StackNode {

//        public int data;
//        public StackNode next;

//        public StackNode()
//        {
//            next = null;
//            data = 0;
//        }
//        public StackNode(int value) {
//            next = null;
//            data = value;
//        }
//    }
//     class StackLL {

//        StackNode node = null;
//        public StackLL Push(StackLL list,int value) {
//            StackNode newNode = new StackNode(value);
//            newNode.next = node;
//            list.node = newNode;
//            return list;
//        }
//        public void Traverse(StackLL list)
//        {
//            while (list.node != null) 
//            {
//                Console.WriteLine(list.node.data);
//                list.node = list.node.next;
//            }
//        }
//        public StackLL Pop(StackLL list) 
//        {
//            if (list.node == null)
//                Console.WriteLine("Stack is empty ");
//            else
//            {
//                list.node = list.node.next;
//            }
//            return list;
//        }
//        public void IsEmpty(StackLL list)
//        {
//            if (list.node == null)
//                Console.WriteLine("Stack is empty");
//            else
//                Console.WriteLine("Stack is not empty");
//        }
//        public int Peek(StackLL list)
//        {
//            return list.node.data;
//        }
//    }
//    class StackLinkedList
//    {
//        static void Main(string[] args)
//        {
//            StackLL stackObj = new StackLL();
//            stackObj.Push(stackObj,1);
//            stackObj.Push(stackObj, 2);
//            stackObj.Push(stackObj, 3);
//            stackObj.Pop(stackObj);
//            stackObj.IsEmpty(stackObj);
//            Console.WriteLine(stackObj.Peek(stackObj));
//            stackObj.Traverse(stackObj);
//            Console.ReadKey();

//        }
//    }
//}
