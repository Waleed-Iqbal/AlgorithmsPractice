using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPractice.Sorting
{
    public static class BinarySearchTree
    {
        public class Node
        {
            int data;
            Node left;
            Node right;
        }

        /// <summary>
        /// Creates a BST for the given array and returns root
        /// </summary>
        /// <param name="numbers">Array of integers</param>
        /// <returns></returns>
        public static Node CreateBST(int[] numbers)
        {
            Node node = new Node();


            return node;
        }


        private static void AddNewNode(Node node)
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
