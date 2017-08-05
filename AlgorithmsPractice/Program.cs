

using System;
namespace AlgorithmsPractice
{
    class Program
    {
        static void Main(String[] args)
        {
            int[] numbers = { 10, 5, 2, 7, 4, 9, 12, 1, 8, 6, 11, 3 };

            numbers = MergeSort.Sort(numbers);

            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
                Console.Write(numbers[i] + " ");

            Console.WriteLine();
        }
    }
}
