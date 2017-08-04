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



        public static int[] MergeSort(int[] numbers)
        {
            numbers = MergeSortRecursive(numbers, 0, numbers.Length);

            return numbers;
        }

        public static int[] MergeSortRecursive(int[] numbers, int left, int right)
        {
            if (left >= right)
            {
                return new int[] { numbers[left] };
            }

            int middle = (left + right) / 2;
            int[] leftHalf = MergeSortRecursive(numbers, left, middle);
            int[] rightHalf = MergeSortRecursive(numbers, middle + 1, right);
            numbers = MergeTwoHalves(leftHalf, rightHalf);

            return numbers;
        }


        private static int[] MergeTwoHalves(int[] left, int[] right)
        {
            int[] sorted = new int[left.Length + right.Length];
            for (int i = 0, j = 0, index = 0; index < left.Length + right.Length; index++)
            {
                if (i < left.Length && j < right.Length && left[i] > right[j])
                {
                    sorted[index] = left[i];
                    i++;
                }
                else if (j < right.Length)
                {
                    sorted[index] = right[j];
                    j++;
                }

                if( j >= right.Length)
                {
                    for (int k = i; k < right.Length; k++) ;
                        //sorted
                }

            }

            return sorted;
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
