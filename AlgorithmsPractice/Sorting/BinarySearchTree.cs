using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPractice
{
    public static class BinarySearchTree
    {
        public class Node
        {
            public Node(int number = 0)
            {
                this.data = number;
                this.left = null;
                this.right = null;
                this.parent = null;
            }
            public int data;
            public Node left;
            public Node right;
            public Node parent;
        }

        /// <summary>
        /// Creates a BST for the given array and returns root. Currently, this is not balanced.
        /// </summary>
        /// <param name="numbers">Array of integers</param>
        /// <returns></returns>
        public static Node CreateBST(int[] numbers)
        {
            Node root = new Node(numbers[0]);
            int totalNodes = numbers.Length;
            Node traverser = root;
            for (int i = 1; i < totalNodes; i++)
            {
                Node node = new Node(numbers[i]);
                traverser = root;
                while (true)
                {

                    if (node.data >= traverser.data && traverser.right == null)
                    {
                        traverser.right = node;
                        break;
                    }
                    else if (node.data <= traverser.data && traverser.left == null)
                    {
                        traverser.left = node;
                        break;
                    }
                    else if (node.data >= traverser.data && traverser.right != null)
                        traverser = traverser.right;
                    else if (node.data <= traverser.data && traverser.left != null)
                        traverser = traverser.left;
                }
            }
            return root;
        }


        public static void GetMax(Node root)
        {
            if(root.right == null)
                Console.WriteLine("Max is: " + root.data);
            else
                GetMax(root.right);
        }


        public static void InOrderTraversal(Node root)
        {
            if (root != null)
            {
                InOrderTraversal(root.left);
                Console.Write(root.data + ", ");
                InOrderTraversal(root.right);
            }
        }

        public static void PreOrderTraversal(Node root)
        {
            if (root != null)
            {
                Console.Write(root.data + ", ");
                PreOrderTraversal(root.left);
                PreOrderTraversal(root.right);
            }
        }

        public static void PostOrderTraversal(Node root)
        {
            if (root != null)
            {
                PreOrderTraversal(root.left);
                PreOrderTraversal(root.right);
                Console.Write(root.data + ", ");
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="node">Node to be inserted</param>
        /// <param name="root">Root node (start of the BST)</param>
        private static void AddNewNode(Node node, Node root)
        {

        }

        /// <summary>
        /// Delete a node if it exists
        /// </summary>
        /// <param name="data">the node to be deleted</param>
        /// <returns>true if node was delete else returns false</returns>
        private static bool DeleteANode(int data)
        {
            bool isNodeDelted = false;


            return isNodeDelted;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number">The number to be searched</param>
        private static Node Find(int number)
        {
            Node node = new Node();
            return node;
        }


        /// <summary>
        /// Returns the numbers of the tree as an ascending order array
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int[] GetSortedNumbers(Node root)
        {
            List<int> sortedNumbers = new List<int>();

            return sortedNumbers.ToArray();
        }


        /// <summary>
        /// Balances the given tree
        /// </summary>
        /// <param name="root"></param>
        public static void BalanceTheTree(Node root)
        {

        }
    }
}
