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
            string firstDocumentPath = @"D:\Projects\AlgorithmsPractice\AlgorithmsPractice\Resources\t1.verne.txt";
            string secondDocumentPath = @"D:\Projects\AlgorithmsPractice\AlgorithmsPractice\Resources\t2.bobsey.txt";
            double computedDistance = DocumentDistance.FindDistance(firstDocumentPath, secondDocumentPath);

            Console.WriteLine(Environment.NewLine + " Distance computed = " + computedDistance);
            Console.WriteLine(Environment.NewLine + " Actual distance = 0.53338963892153224");

            /*
            Document distance of 't1.verne.txt' and 't2.bobsey.txt' is 0.53338963892153224
            Document distance of 't2.bobsey.txt' and 't9.bacon.txt' is 0.52464214746385918
            Document distance of 't8.shakespeare.txt' and 't9.bacon.txt' is 0.55090929545369682
            */



            Console.WriteLine();
        }





    }
}
