//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructures
//{
//    class Graph
//    {
//        public int vertex;
//        public LinkedList<int>[] adjListArray;
//        public Graph(int size)
//        {
//            this.vertex = size;
//            this.adjListArray = new LinkedList<int>[size];
//            for (int i = 0; i < size; i++)
//            {
//                adjListArray[i] = new LinkedList<int>();
//            }
//        }
//    }
//    class GraphOps {
//        Graph graph;
//        public GraphOps(int size)
//        {
//            graph = new Graph(size);
//        }
//        public void AddEdge(int src,int destination) 
//        {
//            graph.adjListArray[src].AddLast(destination);
//            graph.adjListArray[destination].AddLast(src);
//        }
//        public void PrintGraph()
//        {
            
//            for (int i = 0; i < graph.adjListArray.Length; i++)
//            {
//                Console.WriteLine("Adjacency list of vertex {0}", i);
//                Console.Write("head");
//                foreach (var item in graph.adjListArray[i])
//                {
//                    Console.Write("->" + item);
//                }
//                Console.Write("\n");
//            }
//        }

//    }
//    class GraphMain
//    {
//        static void Main(string[] args)
//        {
//            GraphOps graphObj = new GraphOps(5);
//            graphObj.AddEdge(0,1);
//            graphObj.AddEdge(0,4);
//            graphObj.AddEdge(1,2);
//            graphObj.AddEdge(1,3);
//            graphObj.AddEdge(1,4);
//            graphObj.AddEdge(2,3);
//            graphObj.AddEdge(3,4);
//            graphObj.PrintGraph();
//            Console.Read();
//        }
//    }
//}
