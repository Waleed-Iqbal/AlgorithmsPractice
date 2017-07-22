using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomNumberGenerator;

namespace AlgorithmsPractice
{
    class Program
    {
        public struct MatirxPoint
        {
            public int row;
            public int column;
        }

        static void Main(String[] args)
        {
            int numberOfRows = 5;
            int numberOfColumns = 4;

            int[,] randomNumbersMatrix = RandomNumberArrayGenerator.GetRandomNumber2DArray(-20, 20, numberOfRows, numberOfColumns);
            MatirxPoint peak = new MatirxPoint { row = numberOfRows / 2, column = numberOfColumns / 2 };

            Console.WriteLine();
        }


        public static MatirxPoint GetPeakOfTwoDimensionalArray(int[][] matrix, int min, int max, MatirxPoint currentPeak)
        {


            return currentPeak;
        }


    }
}
