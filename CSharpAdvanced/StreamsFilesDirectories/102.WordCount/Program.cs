using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _102.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string expectedReasultPath = Path.Combine("../../../output.txt");
            string[] words = File.ReadAllLines("../../../words.txt");
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                wordCount.Add(word.ToLower(), 0);
            }

            string text = File.ReadAllText("../../../text.txt").ToLower();
            string[] textWords = text.Split(new string[] { " ", ",", ".", "?", "!", "-", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in textWords)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
            }

            Dictionary<string, int> sortedWord = wordCount.
                OrderByDescending(x => x.Value).ToDictionary(k => k.Key, v => v.Value);
            
            List<string> ouputLines = sortedWord.
                Select(kvp => $"{kvp.Key} - {kvp.Value}").ToList();

            File.WriteAllLines(expectedReasultPath, ouputLines);

        }
    }
}
