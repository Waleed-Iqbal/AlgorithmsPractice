using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPractice
{
    public class MatirxPoint
    {
        public int row;
        public int column;
    }
    public static class PeakFinder
    {

        /// <summary>
        /// Finds a peak of a one dimensional integer array
        /// </summary>
        /// <param name="numbers">One dimensional int array</param>
        /// <param name="min">minimum index, should be 0</param>
        /// <param name="max">max index (shoube be the last index of array)</param>
        /// <returns></returns>
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

        /// <summary>
        /// Gets peak of a two dimensional int array.
        /// </summary>
        /// <param name="matrix">The two dimensional array of size greater than 1 r</param>
        /// <param name="currentPeak">a struct having "row" and "column" properties which will act as starting point </param>
        /// <returns></returns>
        public static MatirxPoint GetPeakOfTwoDimensionalArray(int[,] matrix, MatirxPoint currentPeak = null)
        {
            int totalRows = matrix.GetLength(0);
            int totalColumns = matrix.GetLength(1);

            if (totalRows == 1 || totalColumns == 1) // a row or column matrix
                return null;

            if (currentPeak == null)
                currentPeak = new MatirxPoint() { row = totalRows / 2, column = totalColumns / 2 };

            int selectedColumn = currentPeak.column;
            int rowOfSelectedColumn = GetRowOfMaximumValueInAColumn(matrix, selectedColumn);

            if ((rowOfSelectedColumn == 0 && selectedColumn == 0) || // top right corner
                (rowOfSelectedColumn == 0 && selectedColumn == totalColumns - 1) || // top left corner
                (rowOfSelectedColumn == totalRows - 1 && selectedColumn == 0) || // bottom right corner
                (rowOfSelectedColumn == totalRows - 1 && selectedColumn == totalColumns - 1)) // bottom left corner) 
            {
                currentPeak.row = rowOfSelectedColumn;
                currentPeak.column = selectedColumn;
                return currentPeak;
            }

            if (matrix[rowOfSelectedColumn, selectedColumn] >= matrix[rowOfSelectedColumn, selectedColumn - 1] && matrix[rowOfSelectedColumn, selectedColumn] >= matrix[rowOfSelectedColumn, selectedColumn + 1])
            {
                // peak found inside the boundries of the matrix
                currentPeak.row = rowOfSelectedColumn;
                currentPeak.column = selectedColumn;
            }
            else if (matrix[rowOfSelectedColumn, selectedColumn] > matrix[rowOfSelectedColumn, selectedColumn - 1] && matrix[rowOfSelectedColumn, selectedColumn] <= matrix[rowOfSelectedColumn, selectedColumn + 1])
            {
                // going to right half
                currentPeak.column = (currentPeak.column + totalColumns) / 2;
                GetPeakOfTwoDimensionalArray(matrix, currentPeak);
            }
            else
            {
                // going to left half
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


        private static int GetColumnOfMaximumValueInARow(int[,] matrix, int selectedRow)
        {
            // improve this if possible

            int columnNumber = 0;
            int numberOfColumns = matrix.GetLength(1); ;
            int maxInColumn = matrix[0, columnNumber];

            for (int i = 1; i < numberOfColumns; i++)
                if (matrix[0, i] >= maxInColumn)
                {
                    maxInColumn = matrix[0, i];
                    columnNumber = i;
                }

            return columnNumber;
        }
    }
}
