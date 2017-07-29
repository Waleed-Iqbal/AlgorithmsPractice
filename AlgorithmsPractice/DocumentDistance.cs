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
        public static double FindDistance(string firstDocumentPath, string secondDocumentPath)
        {
            double distance = 0;
            string[] document1Words = GetWordsFromDocument(firstDocumentPath);
            string[] document2Words = GetWordsFromDocument(secondDocumentPath);

            Dictionary<string, int> firstDocumentWordsFrequencies = GetFrequenciesOfWords(document1Words);
            Dictionary<string, int> secondDocumentWordsFrequencies = GetFrequenciesOfWords(document2Words);

            long dotProduct = ComputeDotProductOfTwoDocuments(firstDocumentWordsFrequencies, secondDocumentWordsFrequencies);
            double magnitude = MagnitudeOfDocuments(firstDocumentWordsFrequencies) * MagnitudeOfDocuments(secondDocumentWordsFrequencies);

            distance = dotProduct / magnitude;

            return distance;
        }

        private static double MagnitudeOfDocuments(Dictionary<string, int> documentWordsFrequencies)
        {
            long sumOfSquares = 0;
            foreach (var item in documentWordsFrequencies)
                sumOfSquares += item.Value * item.Value;
            double magnitude = Math.Sqrt(sumOfSquares);
            return magnitude;
        }

        private static string[] GetWordsFromDocument(string documentPath)
        {
            string fileContent = System.IO.File.ReadAllText(documentPath);
            //fileContent = new string(fileContent.Where(c => char.IsWhiteSpace(c) || char.IsLetterOrDigit(c)).ToArray());
            fileContent = Regex.Replace(fileContent, @"[^A-Za-z0-9]", " "); // gets only numbers and words
            fileContent = Regex.Replace(fileContent, @"\t|\n|\r", " "); // remove tabs, new line characters and returns
            fileContent = Regex.Replace(fileContent, @"[ ]{2,}", " "); // remove spaces spaning more than 2 characters

            List<string> words = fileContent.ToLower().Split(' ').ToList();
            return words.ToArray();
        }

        private static Dictionary<string, int> GetFrequenciesOfWords(string[] document)
        {
            Dictionary<string, int> wordFrequencies = new Dictionary<string, int>();

            foreach(string word in document)
            {
                if (wordFrequencies.ContainsKey(word))
                    wordFrequencies[word]++;
                else
                    wordFrequencies.Add(word, 1);
            }

            return wordFrequencies;
        }


        private static long ComputeDotProductOfTwoDocuments(Dictionary<string, int> firstDocumentWordsFrequencies, Dictionary<string, int> secondDocumentWordsFrequencies)
        {
            long dotProduct = 0;
            if(firstDocumentWordsFrequencies.Count > secondDocumentWordsFrequencies.Count)
            {
                foreach(var frequency in secondDocumentWordsFrequencies)
                    if (firstDocumentWordsFrequencies.ContainsKey(frequency.Key))
                        dotProduct += firstDocumentWordsFrequencies[frequency.Key] * frequency.Value;
            }
            else
            {
                foreach (var frequency in firstDocumentWordsFrequencies)
                    if (secondDocumentWordsFrequencies.ContainsKey(frequency.Key))
                        dotProduct += secondDocumentWordsFrequencies[frequency.Key] * frequency.Value;
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





























