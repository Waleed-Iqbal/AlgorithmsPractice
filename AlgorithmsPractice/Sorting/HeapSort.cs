
namespace AlgorithmsPractice
{
    public static class HeapSort
    {
        /// <summary>
        /// Starting point of sorting
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static void Sort(int[] numbers)
        {
            BuildMaxHeap(numbers);

            return;
        }

        private static void BuildMaxHeap(int[] numbers)
        {
            for (int i = numbers.Length / 2 - 1; i >= 0; i--)
            {
                MaxHeapify(numbers, i);
            }
        }

        private static void MaxHeapify(int[] numbers, int index)
        {
            int leftNodeIndex = index * 2;
            int rightNodeIndex = leftNodeIndex + 1;
            int largest = index;
            if (leftNodeIndex < numbers.Length && numbers[leftNodeIndex] > numbers[index] )
                largest = leftNodeIndex;
            if (rightNodeIndex < numbers.Length && numbers[rightNodeIndex] > numbers[largest])
                largest = rightNodeIndex;
            if (largest != index)
            {
                numbers[index] = numbers[index] + numbers[largest];
                numbers[largest] = numbers[index] - numbers[largest];
                numbers[index] = numbers[index] - numbers[largest];
                MaxHeapify(numbers, largest);
            }
        }
    }
}
