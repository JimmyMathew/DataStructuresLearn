//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////Closed Hashing or Open Addressing with all 3 probing - Linear,Quadratic and Double Hashing
//namespace DataStructures
//{
//    class HashNode 
//    {
//        public int key;
//        public string data;
//        public HashNode(int key, string value)
//        {
//            this.key = key;
//            this.data = value;
//        }
//        public int GetKey()
//        {
//            return this.key;
//        }
//        public string GetData()
//        {
//            return this.data;
//        }
//    }
//    class HashOps 
//    {
//        HashNode[] table;
//        const int maxSize = 10;
//        #region Utilities
//        public void OpenTable() 
//        {
//            table = new HashNode[maxSize];
//            for (int i = 0; i < maxSize; i++)
//            {
//                table[i] = null;
//            }
//        }
//        public bool CheckOpenSpace()
//        {
//            bool isOpen = false;
//            for (int i = 0; i < maxSize; i++)
//            {
//                if (table[i] == null)
//                    isOpen = true;
//            }
//            return isOpen;
//        }
//        public int Hash1(int key)
//        {
//            return key % maxSize;
//        }
//        public int Hash2(int key)
//        {
//            //Must be non-zero, less than array size, ideally odd
//            return 5 - (key % 5);
//        }
//        #endregion

//        #region Operations
//        //Linear Insert
//        public void LinearInsert(int key, string data)
//        {
//            if (!CheckOpenSpace()) 
//            {
//                Console.WriteLine("Table is at full capacity");
//                return;
//            }
//            int hash = Hash1(key);
//            while (table[hash] != null && table[hash].GetKey() != key)
//            {
//                hash = (hash + 1) % maxSize;
//            }
//            table[hash] = new HashNode(key, data);
//        }
//        //Quadratic Insert
//        public void QuadraticInsert(int key, string data)
//        {
//            if (!CheckOpenSpace())
//            {
//                Console.WriteLine("Table is at full capacity");
//                return;
//            }
//            int hash = Hash1(key);
//            int j = 0;
//            while (table[hash] != null && table[hash].GetKey() != key)
//            {
//                j++;
//                hash = (hash + (j * j)) % maxSize;
//            }
//            table[hash] = new HashNode(key, data);
//        }
//        //Double Hashing
//        public void DoubleHashing(int key, string data)
//        {
//            if (!CheckOpenSpace())
//            {
//                Console.WriteLine("Table is at full capacity");
//                return;
//            }
//            int hash1 = Hash1(key);
//            int hash2 = Hash2(key);
//            while (table[hash1] != null && table[hash1].GetKey() != key)
//            {
//                hash1 = (hash1 + (hash2 * hash2)) % maxSize;
//            }
//            table[hash1] = new HashNode(key, data);
//        }
//        //Get Data through Linear Probing
//        public string GetDataLinearProbing(int key)
//        {
//            int hash = Hash1(key);
//            while (table[hash] != null && table[hash].GetKey() != key)
//            {
//                hash = (hash + 1) % maxSize;
//            }
//            if (table[hash] == null)
//                return "No data mapped with the given key";
//            else
//                return table[hash].GetData();

//        }
//        //Get Data through Quadratic Probing
//        public string GetDataQuadraticProbing(int key)
//        {
//            int hash = Hash1(key);
//            int j = 0;
//            while (table[hash] != null && table[hash].GetKey() != key)
//            {
//                j++;
//                hash = (hash + (j*j)) % maxSize;
//            }
//            if (table[hash] == null)
//                return "No data mapped with the given key";
//            else
//                return table[hash].GetData();

//        }
//        //Get Data through Double Hashing
//        public string GetDataDoubleHashing(int key)
//        {
//            int hash1 = Hash1(key);
//            int hash2 = Hash2(key);
//            while (table[hash1] != null && table[hash1].GetKey() != key)
//            {
//                hash1 = (hash1 + (hash2 * hash2)) % maxSize;
//            }
//            if (table[hash1] == null)
//                return "No data mapped with the given key";
//            else
//                return table[hash1].GetData();

//        }
//        //Remove Data -  Through Linear probing, We can also use the other two methods to remove data
//        public void RemoveData(int key)
//        {
//            int hash = Hash1(key);
//            int hash2 = Hash2(key);
//            while (table[hash] != null && table[hash].GetKey() != key)
//            {
//                hash = (hash + (hash2*hash2)) % maxSize;
//            }
//            if (table[hash] == null)
//            {
//                Console.WriteLine("No data mapped with the given key");
//                return;
//            }

//            else
//                table[hash] = null;
//        }
//        #endregion

//    }

//    class ClosedHashing
//    {
//        static void Main(string[] args)
//        {
//            HashOps hashObj = new HashOps();
//            hashObj.OpenTable();
//            hashObj.LinearInsert(2,"Jimmy");
//            hashObj.LinearInsert(12, "Mathew");
//            hashObj.LinearInsert(22, "John");
//            hashObj.LinearInsert(32, "Mary");
//            hashObj.QuadraticInsert(42, "Jack");
//            hashObj.QuadraticInsert(52, "Daniel");
//            hashObj.DoubleHashing(62, "Rose");
//            hashObj.DoubleHashing(72, "Molly");
//            Console.WriteLine(hashObj.GetDataLinearProbing(32));
//            Console.WriteLine(hashObj.GetDataQuadraticProbing(42));
//            Console.WriteLine(hashObj.GetDataDoubleHashing(62));
//            hashObj.RemoveData(72);
//            Console.WriteLine(hashObj.GetDataLinearProbing(72));
//            Console.ReadKey();
//        }
//    }
//}
