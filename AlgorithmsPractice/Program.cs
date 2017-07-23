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
            int numberOfRows = 5;
            int numberOfColumns = 4;

            int[,] randomNumbersMatrix = RandomNumberArrayGenerator.GetRandomNumber2DArray(-20, 20, numberOfRows, numberOfColumns);
            MatirxPoint peak = new MatirxPoint { row = numberOfRows / 2, column = numberOfColumns / 2 };

            // to print the matrix
            for (int i = 0; i < numberOfRows; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < numberOfColumns; j++)
                    Console.Write(randomNumbersMatrix[i,j] + "   ");
            }

            peak = PeakFinder.GetPeakOfTwoDimensionalArray(randomNumbersMatrix, peak);
            Console.WriteLine(Environment.NewLine + Environment.NewLine + " " + peak.row + ", " + peak.column);

            Console.WriteLine();
        }





    }
}
