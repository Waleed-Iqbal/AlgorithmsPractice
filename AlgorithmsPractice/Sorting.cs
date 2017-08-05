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
            int[] tempArr = new int[numbers.Length];

            numbers = MergeSortRecursive(numbers, tempArr, 0, numbers.Length - 1);

            return numbers;
        }

        public static int[] MergeSortRecursive(int[] numbers, int[] tempArr, int left, int right)
        {
            if (left < right)
            {

                int middle = (left + right) / 2;
                MergeSortRecursive(numbers, tempArr, left, middle);
                MergeSortRecursive(numbers, tempArr, middle + 1, right);
                MergeTwoHalves(numbers, tempArr, left, middle, right);
            }

            return numbers;
        }


        private static int[] MergeTwoHalves(int[] numbers, int[] tempArr, int left, int middle, int right)
        {
            int[] leftArr = new int[middle - left + 1];
            int[] rightArr = new int[right - middle];

            for (int i = 0; i < leftArr.Length; i++)
                leftArr[i] = numbers[i + left];

            for (int i = 0; i < rightArr.Length; i++)
                rightArr[i] = numbers[i + middle + 1];

            int leftRef = 0;
            int rightRef = 0;
            for (int i = left; i <= right; i++)
            {
                if (rightRef == rightArr.Length)
                {
                    int k = i;
                    for (int j = leftRef; j < leftArr.Length; j++)
                    {
                        tempArr[k] = leftArr[leftRef];
                        leftRef++; k++;
                    }
                    break;
                }


                if (leftRef == leftArr.Length)
                {
                    int k = i;

                    for (int j = rightRef; j < rightArr.Length; j++)
                    {
                        tempArr[k] = rightArr[rightRef];
                        rightRef++; k++;
                    }
                    break;
                }

                if (leftArr[leftRef] < rightArr[rightRef])
                {
                    tempArr[i] = leftArr[leftRef];
                    leftRef++;
                }
                else
                {
                    tempArr[i] = rightArr[rightRef];
                    rightRef++;
                }
            }

            for (int i = left; i <= right; i++)
                numbers[i] = tempArr[i];

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
