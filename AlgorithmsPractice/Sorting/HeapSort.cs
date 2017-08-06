
namespace AlgorithmsPractice
{
    public static class HeapSort
    {
        private static class Heap
        {
            public static int[] numbers;
            public static int heapSize;
        }
        /// <summary>
        /// Starting point of sorting
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static void Sort(int[] numbers)
        {
            Heap.numbers = numbers;
            Heap.heapSize = numbers.Length - 1;
            BuildMaxHeap(numbers);
            for (int i = numbers.Length - 1; i > 1; i--)
            {
                numbers[0] = numbers[0] + numbers[i];
                numbers[i] = numbers[0] - numbers[i];
                numbers[0] = numbers[0] - numbers[i];
                Heap.heapSize--;
                MaxHeapify(numbers, 0);
            }
            return;
        }

        public static void BuildMaxHeap(int[] numbers)
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
            if (leftNodeIndex < Heap.heapSize && numbers[leftNodeIndex] > numbers[index])
                largest = leftNodeIndex;
            if (rightNodeIndex < Heap.heapSize && numbers[rightNodeIndex] > numbers[largest])
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
