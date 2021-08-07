//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructures
//{
//    public class QNode
//    {
//        public int data;
//        public QNode next;
//        public QNode(int value)
//        {
//            data = value;
//            next = null;
//        }
//    }
//    public class Queue
//    {
//        public QNode front, rear;
//        public Queue()
//        {
//            rear = front = null;
//        }
//        public Queue Enqueue(Queue queue, int value)
//        {
//            QNode newNode = new QNode(value);
//            if (front == null)
//            {
//                front = newNode;
//                rear = front;
//            }
//            else
//            {
//                rear.next = newNode;
//                rear = rear.next;

//            }
//            return queue;
//        }
//        public Queue Dequeue(Queue queue)
//        {
            
//            if (front == null)
//                Console.WriteLine("Dequeue Exception: Queue is empty.");
//            else
//                front = front.next;

//                return queue;
//        }
//        class QueueList
//        {
//            //static void Main(string[] args)
//            //{
//            //    Queue queueObj = new Queue();
//            //    queueObj.Enqueue(queueObj, 1);
//            //    queueObj.Enqueue(queueObj, 2);
//            //    queueObj.Enqueue(queueObj, 3);
//            //    //queueObj.Dequeue(queueObj);
//            //    //queueObj.Dequeue(queueObj);
//            //    Console.ReadKey();
//            //}
//        }
//    }
//}
