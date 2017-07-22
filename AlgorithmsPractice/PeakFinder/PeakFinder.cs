using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPractice.PeakFinder
{
    class PeakFinder
    {
        public static int GetPeakOfOneDimensionalArray(int[] numbers, int min, int max)
        {
            int middle = (max + min) / 2;
            if (middle == max || middle == min)
            {
                if (numbers[0] >= numbers[1])
                    return numbers[0];
                return numbers[1];
            }

            if (numbers[middle] > numbers[middle - 1] && numbers[middle] > numbers[middle + 1])
                return middle;
            else if (numbers[middle] < numbers[middle - 1])
                return GetPeakOfOneDimensionalArray(numbers, min, middle - 1);
            else return GetPeakOfOneDimensionalArray(numbers, middle + 1, max);
        }


        public static int[,] GetRandomNumber2DArray(int minValue, int maxValue, int numberOfRows, int numberOfColumns)
        {
            int[,] matrix = new int[numberOfRows, numberOfColumns];

            for (int i = 0; i < numberOfRows; i++)
            {
                int[] temp = GetRandomNumberArray(minValue, maxValue, numberOfColumns);
                for (int j = 0; j < numberOfColumns; j++)
                    matrix[i, j] = temp[j];
            }

            return matrix;
        }

        public static int[] GetRandomNumberArray(int min, int max, int size)
        {
            if (min >= max)
                return null;

            Random randomNumberGenerator = new Random();
            int[] numbers = new int[size];
            for (int i = 0; i < size; i++)
                numbers[i] = randomNumberGenerator.Next(min, max);
            return numbers;
        }
    }
}
