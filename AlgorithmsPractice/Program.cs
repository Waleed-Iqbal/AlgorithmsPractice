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
        static void Main(String[] args)
        {
            int numberOfRows = 4;
            int numberOfColumns = 5;

            int[,] randomNumbersMatrix = RandomNumberArrayGenerator.GetRandomNumber2DArray(-20, 20, numberOfRows, numberOfColumns);

            // to print the matrix
            for (int i = 0; i < numberOfRows; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < numberOfColumns; j++)
                    Console.Write(randomNumbersMatrix[i, j] + "   ");
            }

            MatirxPoint peak = PeakFinder.GetPeakOfTwoDimensionalArray(randomNumbersMatrix);
            Console.WriteLine(Environment.NewLine + Environment.NewLine + "Peak at: (" + peak.row + ", " + peak.column + ")");

            Console.WriteLine();
        }





    }
}
