using System;

namespace _102.CharMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string firstWord = input[0];
            string secondWord = input[1];

            string longestWord = firstWord;
            string shortestWord = secondWord;

            if (firstWord.Length < secondWord.Length)
            {
                longestWord = secondWord;
                shortestWord = firstWord;
            }

            var total = CharacterMultiplier(longestWord, shortestWord);
            Console.WriteLine(total);
        }

        private static int CharacterMultiplier(string longestWord, string shortestWord)
        {
            int sum = 0;

            for (int i = 0; i < shortestWord.Length; i++)
            {
                int multiply = longestWord[i] * shortestWord[i];
                sum += multiply;
            }

            for (int i = shortestWord.Length; i < longestWord.Length; i++)
            {
                sum += longestWord[i];
            }

            return sum;
        }
    }
}
