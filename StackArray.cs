//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructures
//{
//    public class StackArr {
//        public int[] data;
//        public int top = -1;
//        public int max;

//        public StackArr(int size) {
//            data = new int[size];
//            max = size;
//        }

//        public StackArr Push(StackArr stack, int value) {
//            if (top != max - 1) {
//                stack.data[top + 1] = value;
//                top++;
//                Console.WriteLine("{0} pushed into the stack",value);
//            }
//            else
//                Console.WriteLine();
//            return stack;
//        }
//        public StackArr Pop(StackArr stack) 
//        {
//            if (top == -1)
//                Console.WriteLine("Stack is empty");
//            else
//            {
//                Console.WriteLine("{0} popped from the stack", stack.data[top]);
//                stack.data[top] = 0 ;
//                top = top - 1;
//            }
//            return stack;
//        }
//        public void Peek(StackArr stack)
//        {
//            if (top == -1)
//                Console.WriteLine("Stack is empty");
//            else
//                Console.WriteLine("Top element : {0}", stack.data[top]);
                 
            
//        }
//        public void IsEmpty(StackArr stack)
//        {
//            if (top == -1)
//                Console.WriteLine("Stack is empty");
//            else
//                Console.WriteLine("Stack is not empty");
//        }
//        public void Traverse(StackArr stack) {
//            if (top == -1)
//                Console.WriteLine("Stack is empty");
//            else {
//                for (int i = 0; i <= top; i++)
//                {
//                    if(stack.data[i] != 0)
//                    Console.WriteLine(stack.data[i]);
//                }
//            }
//        }
        
//    }
    
//    //class Stack
//    //{
//    //    static void Main(string[] args)
//    //    {
//    //        StackArr stack = new StackArr(5);
//    //        Console.WriteLine("Push Operation");
//    //        Console.WriteLine("**************");
//    //        stack.Push(stack, 1);
//    //        stack.Push(stack, 2);
//    //        stack.Push(stack, 3);
//    //        stack.Push(stack, 4);
//    //        Console.WriteLine("Pop Operation");
//    //        Console.WriteLine("**************");
//    //        stack.Pop(stack);
//    //        stack.Pop(stack);
//    //        Console.WriteLine("Stack Traversal");
//    //        Console.WriteLine("**************");
//    //        stack.Traverse(stack);
//    //        Console.WriteLine("Other Operations");
//    //        Console.WriteLine("****************");
//    //        stack.IsEmpty(stack);
//    //        stack.Peek(stack);
//    //        Console.ReadKey();
//    //    }
//    //}
//}
