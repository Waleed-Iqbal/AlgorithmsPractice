

using System;
namespace AlgorithmsPractice
{
    class Program
    {
        static void Main(String[] args)
        {
            int[] numbers = { 10, 5, 2, 7};

            BinarySearchTree.Node root = BinarySearchTree.CreateBST(numbers);

            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
                Console.Write(numbers[i] + " ");

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
