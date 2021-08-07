using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node()
        {
        }
        public Node(int value)
        {
            this.data = value;
        }
    }
    public class BinaryTree
    {
        public Node rootNode;
        public BinaryTree()
        {
            rootNode = null;
        }
        public Node Insert(int value)
        {
            Node newNode = new Node(value);
            if (rootNode == null)
                rootNode = newNode;
            else
                InsertChildren(rootNode, newNode.data);

            return rootNode;
        }
        public void InsertChildren(Node root, int value)
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
            // Do level order traversal until we find  
            // an empty place.  
            while (q.Count != 0)
            {
                root = q.Peek();
                q.Dequeue();
                if (root.left == null)
                {
                    root.left = new Node(value);
                    break;
                }
                else
                    q.Enqueue(root.left);

                if (root.right == null)
                {
                    root.right = new Node(value);
                    break;
                }
                else
                    q.Enqueue(root.right);
            }
        }
        public Node DeleteNode(Node root, int key)
        {
            if (root == null)
                return null;
            Queue<Node> queue = new Queue<Node>();
            Node temp = null;
            Node KeyNode = null;
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                temp = queue.Peek();
                queue.Dequeue();
                if (temp.data == key)
                    KeyNode = temp;
                if (temp.left != null)
                    queue.Enqueue(temp.left);
                if (temp.right != null)
                    queue.Enqueue(temp.right);
            }
            //The deepest node is temp after running this while loop 
            //The key node is the node which contains the value 
            if (KeyNode != null)
            {
                int data = temp.data;
                //Method to delete the deepest node 
                DeleteDeepestNode(root, temp);
                KeyNode.data = data;
            }

            return root;
        }
        public Node DeleteDeepestNode(Node root, Node dNode)
        {
            if (root == null)
                return null;
            Queue<Node> queue = new Queue<Node>();
            Node tNode;
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                tNode = queue.Peek();
                queue.Dequeue();
                if (tNode == dNode)
                {
                    return root;
                }
                if (tNode.left != null)
                    queue.Enqueue(tNode.left);
                if (tNode.right != null)
                    queue.Enqueue(tNode.right);

            }
            return root;
        }
        public void LevelOrderTraversal(Node root)
        {
            if (root == null)
                return;
            Queue<Node> queue = new Queue<Node>();
            Node temp = null;
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                temp = queue.Peek();
                queue.Dequeue();
                Console.WriteLine(temp.data);
                if (temp.left != null)
                    queue.Enqueue(temp.left);
                if (temp.right != null)
                    queue.Enqueue(temp.right);
            }

        }
        public void InOrderTraversal(Node root)
        {

            if (root == null)
                return;
            InOrderTraversal(root.left);
            Console.WriteLine(root.data);
            InOrderTraversal(root.right);
        }
        public void PreOrderTraversal(Node root)
        {
            if (root == null)
                return;
            Console.WriteLine(root.data);
            PreOrderTraversal(root.left);
            PreOrderTraversal(root.right);
        }
        public void PostOrderTraversal(Node root)
        {
            if (root == null)
                return;
            PostOrderTraversal(root.left);
            PostOrderTraversal(root.right);
            Console.WriteLine(root.data);
        }
        public void DisplayTree(Node root)
        {
            if (root == null) return;

            DisplayTree(root.left);
            System.Console.Write(root.data + " ");
            DisplayTree(root.right);
        }
    }

    class BinaryTreeOps
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.Insert(7);
            tree.InsertChildren(tree.rootNode, 4);
            tree.InsertChildren(tree.rootNode, 10);
            tree.InsertChildren(tree.rootNode, 3);
            tree.InsertChildren(tree.rootNode, 5);
            tree.InsertChildren(tree.rootNode, 8);
            tree.InsertChildren(tree.rootNode, 11);
            Console.WriteLine("Level Order Traversal");
            tree.LevelOrderTraversal(tree.rootNode);
            Console.WriteLine("InOrder Traversal");
            tree.InOrderTraversal(tree.rootNode);
            Console.WriteLine("PreOrder Traversal");
            tree.PreOrderTraversal(tree.rootNode);
            Console.WriteLine("PostOrder Traversal");
            tree.PostOrderTraversal(tree.rootNode);
            Console.WriteLine("Level Order Traversal Before deletion ");
            tree.LevelOrderTraversal(tree.rootNode);
            tree.DeleteNode(tree.rootNode, 10);
            Console.WriteLine("Level Order Traversal After deletion ");
            tree.LevelOrderTraversal(tree.rootNode);
            //tree.DisplayTree(tree.rootNode);
            Console.ReadKey();
        }
    }
}
