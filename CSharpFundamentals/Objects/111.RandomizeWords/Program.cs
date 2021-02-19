using System;

namespace _111.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Random rnd = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int randomIndex = rnd.Next(0, input.Length);
                string randomWord = input[randomIndex];
                input[randomIndex] = input[i];
                input[i] = randomWord;
            }

            foreach (string word in input)
            {
                Console.WriteLine(word);
            }
        }
    }
}
