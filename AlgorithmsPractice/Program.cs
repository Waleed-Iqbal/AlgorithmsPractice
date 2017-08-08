

using System;
namespace AlgorithmsPractice
{
    class Program
    {
        static void Main(String[] args)
        {
            int[] numbers = { 10, 5, 2, 7, 4, 6, 1, 9, 3};

            for (int i = 0; i < numbers.Length; i++)
                Console.Write(numbers[i] + ", ");

            BinarySearchTree.Node root = BinarySearchTree.CreateBST(numbers);
            Console.WriteLine();
            BinarySearchTree.ShowMax(root); 
            BinarySearchTree.ShowMin(root);

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
