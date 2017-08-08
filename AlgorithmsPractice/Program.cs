﻿

using System;
namespace AlgorithmsPractice
{
    class Program
    {
        static void Main(String[] args)
        {
            int[] numbers = { 10, 5, 2, 7};

            for (int i = 0; i < numbers.Length; i++)
                Console.Write(numbers[i] + ", ");

            BinarySearchTree.Node root = BinarySearchTree.CreateBST(numbers);

            Console.WriteLine(Environment.NewLine + Environment.NewLine + "After PreOrder:");
            BinarySearchTree.PreOrderTraversal(root);


            Console.WriteLine(Environment.NewLine + Environment.NewLine + "After InOrder:");
            BinarySearchTree.InOrderTraversal(root);


            Console.WriteLine(Environment.NewLine + Environment.NewLine + "After PostOrder:");
            BinarySearchTree.PostOrderTraversal(root);


            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
