//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructures
//{
//    public class Queue
//    {
//        public int[] data;
//        public int front = 0;
//        public int rear = -1;
//        public int max;

//        public Queue(int maxValue)
//        {
//            data = new int[maxValue];
//            max = maxValue;
//        }
//    }
//    public class QueueOperations
//    {
        
//        public Queue Enqueue(Queue queue, int value)
//        {
//            if (queue.rear != queue.max - 1)
//                queue.data[++queue.rear] = value;
//            else
//                Console.WriteLine("Exception: Queue overflow, Can't perform Enqueue operation.");

//            return queue;
//        }
//        public Queue Dequeue(Queue queue)
//        {
//            if (queue.front - 1 == queue.rear)
//                Console.WriteLine("Exception: Queue is Empty, Can't perform Dequeue operation.");
//            else
//            {
//                queue.data[queue.front] = 0;
//                queue.front++;
//            }

//            return queue;
//        }
//        public void Traverse(Queue queue)
//        {
//            for (int i = 0; i <= queue.rear; i++)
//            {
//                if(queue.data[i] != 0)
//                Console.WriteLine(queue.data[i]);
//            }
//        }
//        public Queue IsEmpty(Queue queue)
//        {
//            if (queue.front - 1 == queue.rear)
//                Console.WriteLine("Queue is Empty");
//            else
//                Console.WriteLine("Queue is not empty");

//            return queue;
//        }
//        public int Front(Queue queue)
//        {
//            return queue.data[queue.front];
//        }
//        public int Rear(Queue queue)
//        {
//            return queue.data[queue.rear];
//        }
//    }
//    class QueueArray
//    {
//        static void Main(string[] args)
//        {
//            Queue queue = new Queue(5);
//            QueueOperations queueOps = new QueueOperations();
//            queueOps.IsEmpty(queue);
//            queueOps.Enqueue(queue, 1);
//            queueOps.Enqueue(queue, 2);
//            queueOps.Enqueue(queue, 3);
//            queueOps.Enqueue(queue, 4);
//            queueOps.Enqueue(queue, 5);
//            queueOps.Dequeue(queue);
//            queueOps.Traverse(queue);
//            Console.WriteLine("{0} is the front element",queueOps.Front(queue));
//            Console.WriteLine("{0} is the rear element", queueOps.Rear(queue));
//            queueOps.IsEmpty(queue);
//            Console.ReadKey();

//        }
//    }
//}
