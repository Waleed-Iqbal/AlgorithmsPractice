using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPractice
{
    public struct MatirxPoint
    {
        public int row;
        public int column;
    }
    public static class PeakFinder
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

        public static MatirxPoint GetPeakOfTwoDimensionalArray(int[,] matrix, MatirxPoint currentPeak)
        {
            int selectedColumn = currentPeak.column;
            int rowOfSelectedColumn = GetRowOfMaximumValueInAColumn(matrix, selectedColumn);

            if (matrix[rowOfSelectedColumn, selectedColumn] >= matrix[rowOfSelectedColumn, selectedColumn-1] && matrix[rowOfSelectedColumn, selectedColumn] >= matrix[rowOfSelectedColumn, selectedColumn + 1])
            {
                currentPeak.column = selectedColumn;
                currentPeak.row = rowOfSelectedColumn;
            }
            else
            {
                currentPeak.column = currentPeak.column / 2;
                GetPeakOfTwoDimensionalArray(matrix, currentPeak);
            }

                return currentPeak;
        }

        /// <summary>
        /// Returns row index of the maximum value in a column
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="numberOfRows">Number of rows in the given matrix</param>
        /// <param name="selectedColumn">The column from which the max value is to be searched</param>
        /// <returns></returns>
        private static int GetRowOfMaximumValueInAColumn(int[,] matrix, int selectedColumn)
        {
            // improve this if possible

            int rowOfSelectedColumn = 0; ;
            int numberOfRows = matrix.GetLength(0);
            int maxInColumn = matrix[rowOfSelectedColumn, selectedColumn];

            for (int i = 1; i < numberOfRows; i++)
                if (matrix[i, selectedColumn] >= maxInColumn)
                {
                    maxInColumn = matrix[i, selectedColumn];
                    rowOfSelectedColumn = i;
                }

            return rowOfSelectedColumn;
        }
    }
}
