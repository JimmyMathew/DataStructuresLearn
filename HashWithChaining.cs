//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructures
//{
//    class HashNode {
//        public int key;
//        public string data;
//        public HashNode next;

//        public HashNode(int keyValue,string value)
//        {
//            key = keyValue;
//            data = value;
//            next = null;
//        }
//        public int getKey()
//        {
//            return this.key;
//        }
//        public string getData()
//        {
//            return this.data;
//        }
//        public HashNode getNext()
//        {
//            return this.next;
//        }
//        public void setData(string value)
//        {
//            this.data = value;
//        }
//        public void setNext(HashNode next)
//        {
//            this.next = next;
//        }
//    }
//    class HashOps {
//        HashNode[] table;
//        const int size = 10;
//        public int HashFunction(int key)
//        {
//            return (key % size);
//        }
//        public void OpenTable() {
//            table = new HashNode[size];
//            for (int i = 0; i < size; i++)
//            {
//                table[i] = null;
//            }
//        }
//        public void Insert(int key, string value)
//        {
//            int hash = HashFunction(key);
//            if (table[hash] == null)
//                table[hash] = new HashNode(key, value);
//            else
//            {
//                HashNode entry = table[hash];
//                while (entry.next != null && entry.key != key)
//                    entry = entry.next;
//                if (entry.getKey() == key)

//                    entry.setData(value);
//                else
//                    entry.setNext(new HashNode(key, value));

//            }
//        }
//        public string Get(int key)
//        {
//            int hash = HashFunction(key);
//            if (table[hash] == null)
//                return "Invalid Key";
//            else
//            {
//                HashNode entry = table[hash];
//                while (entry.next != null && entry.key != key)
//                        entry = entry.next;

//                if (entry.getKey() == key)
//                    return entry.getData() == "" ? "No data present" : entry.getData();
//                else
//                    return "Invalid Key";
//            }
//        }
//        public void Remove(int key) {
//            int hash = HashFunction(key);
//            if (table[hash] == null)
//                Console.WriteLine("Invalid Key");
//            else 
//            {
//                HashNode entry = table[hash];
//                HashNode previous = null;
//                while (entry.next != null && entry.getKey() != key)
//                {
//                    if (entry.next.key == key)
//                        previous = entry;
//                        entry = entry.next;
//                }
//                if (previous == null)
//                    table[hash] = entry.next;
//                else
//                    previous.next = entry.next;
//            }
                
//        }
//    }
//    class HashWithChaining
//    {
//        static void Main(string[] args)
//        {
//            HashOps hashObj = new HashOps();
//            hashObj.OpenTable();
//            hashObj.Insert(1, "Jimmy");
//            hashObj.Insert(2, "Mathew");
//            hashObj.Insert(4, "John");
//            hashObj.Insert(5, "Mary");
//            hashObj.Insert(12, "");
//            hashObj.Insert(22, "August");
//            hashObj.Remove(12);
//            hashObj.Remove(2);
//            Console.WriteLine(hashObj.Get(22));
//            Console.WriteLine(hashObj.Get(12));
//            Console.WriteLine(hashObj.Get(56));
//            Console.ReadKey();
            
//        }
//    }
//}
