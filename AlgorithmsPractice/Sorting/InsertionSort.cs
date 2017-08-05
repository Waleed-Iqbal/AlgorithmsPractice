
namespace AlgorithmsPractice
{
    public static class InsertionSort
    {
        /// <summary>
        /// Does insertion sort on an array
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int[] Sort(int[] numbers)
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
    }
}
