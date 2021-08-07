//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructures
//{
//    class Heap
//    {
//        public int[] array;
//        public int heapSize;
//        public int arraySize;
//        public Heap()
//        {
//            heapSize = 0;
//            arraySize = 0;
//            array = new int[arraySize];
            
//        }
//        public Heap(int size)
//        {
//            array = new int[size];
//        }
//    }
//    class MinHeap {
//        Heap heap = new Heap(7);
//        public void Insert(int value) 
//        {
//            if (heap.heapSize == heap.array.Length)
//            { 
//                Console.WriteLine("Heap is at it's maximum capacity");
//                return;
//            }
//            heap.array[heap.heapSize] = value;
//            heap.heapSize++;
//            ShiftUp(heap.heapSize - 1);

//        }
//        public void RemoveMin()
//        {

//            if (heap.heapSize == 0)
//            {
//                Console.WriteLine("Heap is empty");
//                return;
//            }
//            heap.array[0] = heap.array[heap.heapSize - 1];
//            heap.heapSize--;

//            if (heap.heapSize > 0)
//                ShiftDown(0);
//        }
    
//        public void ShiftUp(int index)
//        {
//            int parentIndex, temp;
//            if (index != 0)
//            {
//                parentIndex = getParentIndex(index);
//                if (heap.array[parentIndex] > heap.array[index])
//                {
//                    temp = heap.array[parentIndex];
//                    heap.array[parentIndex] = heap.array[index];
//                    heap.array[index] = temp;
//                    ShiftUp(parentIndex);
//                }

//            }
//        }
//        public void ShiftDown(int index)
//        {
//            int leftIndex, rightIndex, minIndex,temp;
//            leftIndex = getLeftChildIndex(index);
//            rightIndex = getRightChildIndex(index);
//            if (rightIndex >= heap.heapSize)
//            {
//                if (leftIndex >= heap.heapSize)
//                    return;
//                else
//                    minIndex = leftIndex;

//            }
//            if (heap.array[leftIndex] <= heap.array[rightIndex])
//                    minIndex = leftIndex;
//                else
//                    minIndex = rightIndex;
            
           
//            if (heap.array[index] > heap.array[minIndex])
//            {
//                temp = heap.array[index];
//                heap.array[index] = heap.array[minIndex];
//                heap.array[minIndex] = temp;
//                ShiftDown(minIndex);
//            }
//        }
//        public void BuildMinHeap(int[] inputArray) 
//        {
//            if (heap.heapSize > 0)
//            {
//                Array.Resize(ref heap.array,inputArray.Length);
//                heap.heapSize = 0;
//                for (int i = 0; i < heap.array.Length; i++)
//                {
//                    heap.array[i] = inputArray[i];
//                    heap.heapSize++;
//                }
//            }
//            for (int i = (heap.heapSize-1)/2; i >= 0; i--)
//            {
//                    MinHeapify(i);
//            }
//        }
//        public void MinHeapify(int index)
//        {
//            int left = getLeftChildIndex(index);
//            int right = getRightChildIndex(index);
//            int parent = index;
//            if (left < heap.heapSize && heap.array[left] < heap.array[index])
//                parent = left;
//            if (right < heap.heapSize && heap.array[right] < heap.array[parent])
//                parent = right;

//            if (parent != index)
//            {
//                swap(ref heap.array, index, parent);
//                MinHeapify(parent);
//            }


//        }
//        private int getParentIndex(int index)
//        {
//            return (index - 1) / 2;
//        }
//        private int getLeftChildIndex(int i)
//        {
//            return (2*i) + 1;
//        }
//        private int getRightChildIndex(int i)
//        {
//            return (2 *i) + 2;
//        }
//        public int getMinimum(int left, int right)
//        {
//            return (heap.array[left] < heap.array[right] ? left : right);
//        }
//        public void swap(ref int[] input, int a, int b)
//        {
//            int temp = input[a];
//            input[a] = input[b];
//            input[b] = temp;
//        }
//    }
//    class HeapMain
//    {
//        static void Main(string[] args)
//        {
//            MinHeap heapObj = new MinHeap();
//            heapObj.Insert(8);
//            heapObj.Insert(5);
//            heapObj.Insert(10);
//            heapObj.Insert(3);
//            heapObj.Insert(1);
//            heapObj.Insert(7);
//            heapObj.Insert(20);
//            heapObj.RemoveMin();
//            int[] arr = { 77, 64, 21, 89, 92, 17, 30, 42, 50, 2 };
//            heapObj.BuildMinHeap(arr);
//            Console.Read();
//        }
//    }
//}
