//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructures
//{
//    public class Node
//    {
//        public Node left;
//        public Node right;
//        public int data;
//        public Node() { }
//        public Node(int value)
//        {
//            this.data = value;
//        }
//    }
//    public class AVLTree
//    {
//        Node root;
//        //Insert operations
//        public Node InsertRec(Node rootNode, int data)
//        {
//            Node newNode = new Node(data);
//            if (rootNode == null)
//                rootNode = newNode;
//            else
//            {
//                if (data < rootNode.data)
//                {
//                    rootNode.left = InsertRec(rootNode.left, data);
//                    rootNode = BalanceTree(rootNode);
//                }
//                else
//                {
//                    rootNode.right = InsertRec(rootNode.right, data);
//                    rootNode = BalanceTree(rootNode);
//                }
//            }

//            return rootNode;

//        }
//        public Node DeleteRec(Node root, int data)
//        {
//            if (root == null)
//                return root;
//            else if (data < root.data)
//                root.left = DeleteRec(root.left, data);
//            else if (data > root.data)
//                root.right = DeleteRec(root.right, data);
//            else
//            {

//                if (root.left == null)
//                    return root.right;
//                else if (root.right == null)
//                    return root.left;

//                root.data = minValue(root.right);

//                root.right = DeleteRec(root.right, root.data);
//            }
//            //Balance the tree after deletion
//            root = BalanceTree(root);

//            return root;
//        }
//        public Node BalanceTree(Node currentNode)
//        {
//            int balanceFactor = BalanceFactor(currentNode);
//            if (balanceFactor > 1)
//            {
//                //LL Scenario
//                if (BalanceFactor(currentNode.left) > 0)
//                    currentNode = RotateRight(currentNode);
//                else
//                    //LR Scenario
//                    currentNode = RotateLR(currentNode);
//            }
//            else if (balanceFactor < -1)
//            {
//                //RR Scenario
//                if (BalanceFactor(currentNode.right) > 0)
//                    currentNode = RotateLeft(currentNode);
//                else
//                    //RL Scenario
//                    currentNode = RotateRL(currentNode);
//            }

//            return currentNode;
//        }

//        public void InOrderRec(Node node)
//        {
//            if (node != null)
//            {
//                InOrderRec(node.left);
//                Console.WriteLine(node.data);
//                InOrderRec(node.right);
//            }
//        }
//        //Utility Methods
//        //Get the height of the tree 
//        public int Height(Node node)
//        {
//            int height = 0;
//            if (node != null)
//            {
//                int left = Height(node.left);
//                int right = Height(node.left);
//                int maxHeight = max(left, right);
//                height = maxHeight + 1;
//            }
//            return height;
//        }
//        public int BalanceFactor(Node node)
//        {
//            int left = Height(node.left);
//            int right = Height(node.right);
//            return left - right;
//        }
//        //Get the max of two integers
//        public int max(int number1, int number2)
//        {
//            return number1 > number2 ? number1 : number2;
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
//        //Left Left Scenario
//        public Node RotateRight(Node parent)
//        {
//            Node pivot;
//            pivot = parent.left;
//            parent.left = pivot.right;
//            pivot.right = parent;
//            return pivot;
//        }
//        //Right Right Scenario
//        public Node RotateLeft(Node parent)
//        {

//            Node pivot = parent.right;
//            parent.right = pivot.left;
//            pivot.left = parent;
//            return pivot;
//        }
//        //Left Right Scenario
//        public Node RotateLR(Node parent)
//        {
//            Node pivot = parent.left;
//            parent.left = RotateLeft(pivot);
//            return RotateRight(parent);
//        }
//        //Right Left Scenario
//        public Node RotateRL(Node parent)
//        {
//            Node pivot = parent.right;
//            parent.right = RotateRight(pivot);
//            return RotateLeft(parent);
//        }
//        //Direct Methods 
//        public AVLTree Insert(AVLTree tree, int data)
//        {
//            root = InsertRec(root, data);
//            return tree;
//        }
//        public AVLTree Delete(AVLTree tree, int data)
//        {
//            root = DeleteRec(root, data);
//            return tree;
//        }
//        public void InOrder(AVLTree tree)
//        {
//            InOrderRec(tree.root);
//        }


//    }
//    class AVLTreeOperations
//    {
//        static void Main(string[] args)
//        {
//            AVLTree avlTree = new AVLTree();
//            avlTree.Insert(avlTree, 5);
//            avlTree.Insert(avlTree, 3);
//            avlTree.Insert(avlTree, 7);
//            avlTree.Insert(avlTree, 2);
//            avlTree.Insert(avlTree, 1);
//            avlTree.Delete(avlTree, 7);
//            avlTree.InOrder(avlTree);
//            Console.ReadKey();

//        }
//    }
//}
