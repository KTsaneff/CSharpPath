using System;

namespace _09.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());
            string input = string.Empty;
            int bestSumOFOnes = 0;
            int sampleCounter = 0;
            int bestBegIndex = 0;
            int bestSum = 0;
            string bestSequence = string.Empty;
            int bestSample = 0;

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                string numbers = input.Replace("!", "");
                string[] dnaParts = numbers.Split("0", StringSplitOptions.RemoveEmptyEntries);

                int count = 0;
                int sum = 0;
                string longestSeqOfOnes = String.Empty;
                sampleCounter++;

                foreach (string element in dnaParts)
                {
                    if (element.Length > count)
                    {
                        count = element.Length;
                        longestSeqOfOnes = element;
                    }

                    sum += element.Length;
                }

                int begIndex = numbers.IndexOf(longestSeqOfOnes);

                if (count > bestSumOFOnes ||
                    (count == bestSumOFOnes && begIndex < bestBegIndex) || (count == bestSumOFOnes && begIndex == bestBegIndex && sum > bestSum) || sampleCounter ==1)
                {
                    bestSumOFOnes = count;
                    bestSequence = numbers;
                    bestBegIndex = begIndex;
                    bestSum = sum;
                    bestSample = sampleCounter;
                }
            }

            char[] result = bestSequence.ToCharArray();

            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSum}.");
            Console.WriteLine($"{string.Join(" ",result)}");
        }
    }
}
