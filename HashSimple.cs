//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructures
//{
//    class HashOperations 
//    {
//        public static int MAX = 1000;
//        public bool[,] hash = new bool[MAX+1,2];
       
//        public void Insert(int[] valuesArr) 
//        {
//            for (int i = 0; i < valuesArr.Length; i++)
//            {
//                if (valuesArr[i] > 0)
//                    hash[valuesArr[i], 0] = true;
//                else
//                    hash[Math.Abs(valuesArr[i]), 1] = true;
//            }
//        }
//        public bool Search(int num)
//        {
//            if (num >= 0)
//                return hash[num, 0] == true ? true : false;
//            else
//                return hash[Math.Abs(num),1] == true ? true : false;
//        }

//    }
//    class HashSimple
//    {
        
//        static void Main(string[] args)
//        {
//            HashOperations hashObj = new HashOperations();
//            int[] arr = { -1, 9, -5, -8, -5, -2 };
//            hashObj.Insert(arr);
//            Console.WriteLine(hashObj.Search(9));
//            Console.WriteLine(hashObj.Search(-2));
//            Console.WriteLine(hashObj.Search(12));
//            Console.ReadKey();
//        }

//    }
     
//}
