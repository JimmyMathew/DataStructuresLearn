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
        public Node leftChild, rightChild;
        public Node() { }
        public Node(int value)
        {
            data = value;
        }
    }
    public class BinaryTree {
        public Node root;
        public  int depth(Node node)
        {
            int d = 0;
            while (node != null)
            {
                d++;
                node = node.leftChild;
            }
            return d;
        }
        public int countNumNodes(Node root)
        {
            if (root == null)
                return (0);
            return (1 + countNumNodes(root.leftChild) + countNumNodes(root.rightChild));
        }

        public bool IsFullBinaryTree(Node node) {
            depth(node);
            //If the node is null, it is by default a FBT
            if (node == null)
                return true;
            //If the node's left is null, right should also be null
            if (node.leftChild == null && node.rightChild == null)
                return true;
            //if the node is not null, Pass the left and right nodes and check if both are FBT 
            if (node.leftChild != null && node.rightChild != null)
                return (IsFullBinaryTree(node.leftChild) && IsFullBinaryTree(node.rightChild));

            return false;
        }
        public bool IsPerfectBinaryTree(Node node, int depth, int level)
        {
            // Check if the tree is empty
            if (node == null)
                return true;

            // If for children
            if (node.leftChild == null && node.rightChild == null)
                return (depth == level + 1);

            if (node.leftChild == null || node.rightChild == null)
                return false;

            return IsPerfectBinaryTree(node.leftChild, depth, level + 1) && IsPerfectBinaryTree(node.rightChild, depth, level + 1);
        }
        public bool IsCompleteBinaryTree(Node node, int index, int count)
        {
            // Check if the tree is empty
            if (node == null)
                return true;

            if (index >= count)
                return false;

            return (IsCompleteBinaryTree(node.leftChild, 2 * index + 1, count)
                && IsCompleteBinaryTree(node.rightChild, 2 * index + 2, count));
        }

    }
    class BinaryTreeTypes
    {
        static void Main(string[] args)
        {
            // Full Binary Tree
            //BinaryTree tree = new BinaryTree();
            //tree.root = new Node(1);
            //tree.root.leftChild = new Node(2);
            //tree.root.rightChild = new Node(3);
            //tree.root.leftChild.leftChild = new Node(4);
            //tree.root.leftChild.rightChild = new Node(5);
            //tree.root.rightChild.leftChild = new Node(6);
            ////tree.root.rightChild.rightChild = new Node(7);
            //Console.WriteLine(tree);
            //if (tree.IsFullBinaryTree(tree.root))
            //    Console.WriteLine("Full Binary Tree");
            //else
            //    Console.WriteLine("Not a Full Binary Tree");

            //// Perfect Binary Tree
            //BinaryTree tree = new BinaryTree();
            //tree.root = new Node(1);
            //tree.root.leftChild = new Node(2);
            //tree.root.rightChild = new Node(3);
            //tree.root.leftChild.leftChild = new Node(4);
            //tree.root.leftChild.rightChild = new Node(5);
            //tree.root.rightChild.leftChild = new Node(6);
            //tree.root.rightChild.rightChild = new Node(7);

            //if (tree.IsPerfectBinaryTree(tree.root,tree.depth(tree.root),0))
            //    Console.WriteLine("Perfect Binary Tree");
            //else
            //    Console.WriteLine("Not a Perfect Binary Tree");

            // Complete Binary Tree
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(1);
            tree.root.leftChild = new Node(2);
            tree.root.rightChild = new Node(3);
            tree.root.leftChild.leftChild = new Node(4);
            tree.root.leftChild.rightChild = new Node(5);
            tree.root.rightChild.leftChild = new Node(6);

            
            if (tree.IsCompleteBinaryTree(tree.root, 0,tree.countNumNodes(tree.root)))
                Console.WriteLine("Complete Binary Tree");
            else
                Console.WriteLine("Not a complete Binary Tree");


            Console.ReadKey();
        }
    }
}
