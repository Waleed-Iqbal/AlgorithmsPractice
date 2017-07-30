using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomNumberGenerator;

namespace AlgorithmsPractice
{
    class Program
    {
        static void Main(String[] args)
        {
            int[] numbers = { 14, 33, 27, 10, 35, 19, 42, 44 };

            numbers = Sorting.InsertionSort(numbers);

            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
                Console.Write(numbers[i] + " ");

            Console.WriteLine();
        }





    }
}
