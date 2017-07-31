using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPractice
{
    public static class Sorting
    {
        public static int[] InsertionSort(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++) // iterating through unsorted array
                if (numbers[i] < numbers[i - 1])
                    for (int j = i; j >= 1 ; j--) // iterating through sorted array
                        if (numbers[j] < numbers[j - 1])
                        {
                            // swaping numbers
                            numbers[j] = numbers[j] + numbers[j - 1];
                            numbers[j-1] = numbers[j] - numbers[j - 1];
                            numbers[j] = numbers[j] - numbers[j - 1];
                        }
            return numbers;
        }



        public static int[] MergeSort(int[] numbers)
        {



            return numbers;
        }

        public static int[] HeapSort(int[] numbers)
        {
            return numbers;
        }

        private static int[] MaxHeapify()
        {
            int[] numbers = { };

            return numbers;
        }

        private static int Max()
        {
            int max = 0;

            return max;
        }

        private static int ExtractMax()
        {
            int max = 0;
            return max;
        }

        private static int[] BuildMaxHeap()
        {
            int[] numbers = { };


            return numbers;
        }

    }
}
