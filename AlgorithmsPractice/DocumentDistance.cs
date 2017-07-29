using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPractice
{
    public static class DocumentDistance
    {
        public static long FindDistance(string document1, string document2)
        {
            long distance = 0;
            string[] document1Words = GetWordsFromDocument(document1);
            string[] document2Words = GetWordsFromDocument(document2);


            Dictionary<string, int> document1WordsFrequencies = GetFrequenciesOfWords(document1Words);
            Dictionary<string, int> document2WordsFrequencies = GetFrequenciesOfWords(document2Words);



            return distance;
        }
        

        private static string[] GetWordsFromDocument(string document)
        {
            List<string> words = new List<string>();

            document = document.Replace("[-+,<.?/\\{}()!@#$%^&*]", " ");
            words = document.Split(' ').ToList();

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
                    wordFrequencies.Add(word,0);
            }


            return wordFrequencies;
        }


        private static long ComputeDotProductOfTwoDocuments()
        {
            long dotProduct = 0;


            return dotProduct;
        }
    }
}
/*
 
   Document distance of 't1.verne.txt' and 't2.bobsey.txt' is 0.53338963892153224

   Document distance of 't2.bobsey.txt' and 't9.bacon.txt' is 0.52464214746385918

   Document distance of 't8.shakespeare.txt' and 't9.bacon.txt' is 0.55090929545369682


 */





























