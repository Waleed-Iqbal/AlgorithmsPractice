
namespace AlgorithmsPractice { 
    public static class MergeSort
    {
        public static int[] Sort(int[] numbers)
        {
            int[] tempArr = new int[numbers.Length];
            numbers = MergeSortRecursive(numbers, tempArr, 0, numbers.Length - 1);
            return numbers;
        }

        private static int[] MergeSortRecursive(int[] numbers, int[] tempArr, int left, int right)
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
            // need some comments here
            for (int i = left; i <= right; i++)
                numbers[i] = tempArr[i];

            return numbers;
        }

    }
}
