using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AlgorithmsPractice
{
    public static class DocumentDistance
    {


        /*
         * //Main
         * //----
           string firstDocumentPath = @"D:\Projects\AlgorithmsPractice\AlgorithmsPractice\Resources\t8.shakespeare.txt";
            string secondDocumentPath = @"D:\Projects\AlgorithmsPractice\AlgorithmsPractice\Resources\t9.bacon.txt";
            double computedDistance = DocumentDistance.FindDistance(firstDocumentPath, secondDocumentPath);

            Console.WriteLine(Environment.NewLine + " Distance computed = " + computedDistance);
            Console.WriteLine(Environment.NewLine + " Actual distance = 0.52464214746385918");

            //Document distance of 't1.verne.txt' and 't2.bobsey.txt' is 0.53338963892153224
            //Document distance of 't2.bobsey.txt' and 't9.bacon.txt' is 0.52464214746385918
            //Document distance of 't8.shakespeare.txt' and 't9.bacon.txt' is 0.55090929545369682



            Console.WriteLine();
         */
        public static double FindDistance(string firstDocumentPath, string secondDocumentPath)
        {
            double distance = 0;
            string[] firstDocumentWords = GetWordsFromDocument(firstDocumentPath);
            string[] secondDocumentWords = GetWordsFromDocument(secondDocumentPath);

            Dictionary<string, int> firstDocumentWordsFrequencies = GetFrequenciesOfWords(firstDocumentWords);
            Dictionary<string, int> secondDocumentWordsFrequencies = GetFrequenciesOfWords(secondDocumentWords);

            ulong dotProduct = ComputeDotProductOfTwoDocuments(firstDocumentWordsFrequencies, secondDocumentWordsFrequencies);
            double magnitude = MagnitudeOfDocuments(firstDocumentWordsFrequencies, secondDocumentWordsFrequencies);

            distance = Math.Acos( dotProduct / magnitude);

            return distance;
        }

        private static double MagnitudeOfDocuments(Dictionary<string, int> firstDocumentWordsFrequencies, Dictionary<string, int> secondDocumentWordsFrequencies)
        {
            double magnitudeOfFirstDocument = 0;
            double magnitudeOfSecondDocument = 0;


            foreach (var item in firstDocumentWordsFrequencies)
                if (secondDocumentWordsFrequencies.ContainsKey(item.Key))
                    magnitudeOfFirstDocument += Convert.ToUInt64(item.Value * item.Value);
            magnitudeOfFirstDocument = Math.Sqrt(magnitudeOfFirstDocument);

            foreach (var item in secondDocumentWordsFrequencies)
                if (firstDocumentWordsFrequencies.ContainsKey(item.Key))
                    magnitudeOfSecondDocument += Convert.ToUInt64(item.Value * item.Value);
            magnitudeOfSecondDocument = Math.Sqrt(magnitudeOfSecondDocument);


            return magnitudeOfFirstDocument * magnitudeOfSecondDocument;
        }

        private static string[] GetWordsFromDocument(string documentPath)
        {
            string fileContent = System.IO.File.ReadAllText(documentPath);
            //fileContent = new string(fileContent.Where(c => char.IsWhiteSpace(c) || char.IsLetterOrDigit(c)).ToArray());
            fileContent = Regex.Replace(fileContent, @"[^A-Za-z0-9]", " "); // gets only numbers and words
            //fileContent = Regex.Replace(fileContent, @"\t|\n|\r", " "); // remove tabs, new line characters and returns
            fileContent = Regex.Replace(fileContent, @"[ ]{1,}", " "); // remove spaces spaning more than 2 characters

            List<string> words = fileContent.ToLower().Split(' ').ToList();
            return words.ToArray();
        }

        private static Dictionary<string, int> GetFrequenciesOfWords(string[] document)
        {
            Dictionary<string, int> wordFrequencies = new Dictionary<string, int>();

            foreach (string word in document)
                if (wordFrequencies.ContainsKey(word))
                    wordFrequencies[word]++;
                else
                    wordFrequencies.Add(word, 1);

            return wordFrequencies;
        }


        private static ulong ComputeDotProductOfTwoDocuments(Dictionary<string, int> firstDocumentWordsFrequencies, Dictionary<string, int> secondDocumentWordsFrequencies)
        {
            ulong dotProduct = 0;
            if (firstDocumentWordsFrequencies.Count > secondDocumentWordsFrequencies.Count)
            {
                foreach (var frequency in firstDocumentWordsFrequencies)
                    if (firstDocumentWordsFrequencies.ContainsKey(frequency.Key) && secondDocumentWordsFrequencies.ContainsKey(frequency.Key))
                        dotProduct += Convert.ToUInt64(secondDocumentWordsFrequencies[frequency.Key] * frequency.Value);
            }
            else
            {
                foreach (var frequency in secondDocumentWordsFrequencies)
                    if (firstDocumentWordsFrequencies.ContainsKey(frequency.Key) && secondDocumentWordsFrequencies.ContainsKey(frequency.Key))
                        dotProduct += Convert.ToUInt64(firstDocumentWordsFrequencies[frequency.Key] * frequency.Value);
            }

            return dotProduct;
        }
    }
}
/*
 
   Document distance of 't1.verne.txt' and 't2.bobsey.txt' is 0.53338963892153224

   Document distance of 't2.bobsey.txt' and 't9.bacon.txt' is 0.52464214746385918

   Document distance of 't8.shakespeare.txt' and 't9.bacon.txt' is 0.55090929545369682


 */





























