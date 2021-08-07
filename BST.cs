//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructures
//{
//    public class Node
//    {
//        public int data;
//        public Node left;
//        public Node right;

//        public Node()
//        {
//        }
//        public Node(int item)
//        {
//            this.data = item;
//        }
//    }
//    public class BinarySearchTree
//    {
//        public Node root;
//        public BinarySearchTree()
//        {
//            root = null;
//        }
//        //Traversal
//        public void Inorder(Node root)
//        {
//            if (root != null)
//            {
//                Inorder(root.left);
//                Console.WriteLine(root.data);
//                Inorder(root.right);
//            }
//        }
//        //Insertion
//        public Node Insert(Node root, int key)
//        {
//            Node newNode = new Node(key);
//            if (root == null)
//            {
//                root = newNode;
//                return root;
//            }
//            if (key < root.data)
//                root.left = Insert(root.left, key);
//            else
//                root.right = Insert(root.right, key);
//            return root;
//        }
//        public Node Delete(Node root, int data)
//        {
//            if (root == null)
//                return root;
//            else if (data < root.data)
//                root.left = Delete(root.left, data);
//            else if (data > root.data)
//                root.right = Delete(root.right, data);
//            else
//            {

//                if (root.left == null)
//                    return root.right;
//                else if (root.right == null)
//                    return root.left;

//                root.data = minValue(root.right);

//                root.right = Delete(root.right, root.data);
//            }
//            return root;
//        }
//        private int minValue(Node root)
//        {
//            int minVal = root.data;
//            while (root.left != null)
//            {
//                minVal = root.left.data;
//                root = root.left;
//            }
//            return minVal;
//        }
//        public void InsertRec(int key)
//        {
//            root = Insert(root, key);
//        }
//        public void InorderRec()
//        {
//            Inorder(root);
//        }
//        public void DeleteRec(int key)
//        {
//            root = Delete(root, key);
//        }


//    }
//    class BST
//    {
//        static void Main(string[] args)
//        {
//            BinarySearchTree tree = new BinarySearchTree();

//            tree.InsertRec(50);
//            tree.InsertRec(30);
//            tree.InsertRec(20);
//            tree.InsertRec(40);
//            tree.InsertRec(70);
//            tree.InsertRec(60);
//            tree.InsertRec(80);
//            tree.DeleteRec(70);
//            tree.DeleteRec(80);
//            tree.InorderRec();
//            Console.ReadKey();

//        }
//    }
//}
