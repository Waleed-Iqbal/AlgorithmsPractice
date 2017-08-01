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
                    for (int j = i; j >= 1; j--) // iterating through sorted array
                        if (numbers[j] < numbers[j - 1])
                        {
                            // swaping numbers
                            numbers[j] = numbers[j] + numbers[j - 1];
                            numbers[j - 1] = numbers[j] - numbers[j - 1];
                            numbers[j] = numbers[j] - numbers[j - 1];
                        }
            return numbers;
        }



        public static int[] MergeSort(int[] numbers, int left = 0, int right = 0)
        {
            if (right == 0) right = numbers.Length;
            int middle = (left + right) / 2;
            MergeSort(numbers, left, middle);
            MergeSort(numbers, middle + 1, right);
            MergeTwoHalves(numbers, left, right);

            return numbers;
        }

        private static void MergeTwoHalves(int[] numbers, int left, int right)
        {
            int middle = (left + right) / 2;
            for (int i = left, j = middle + 1; i <= middle;)
            {
                if(numbers[i] > numbers[j])
                {
                    numbers[i] = numbers[i] + numbers[j];
                    numbers[j] = numbers[i] - numbers[j];
                    numbers[i] = numbers[i] - numbers[j];

                }
            }
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
