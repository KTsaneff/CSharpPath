using System;
using System.Linq;

namespace _003.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string sample = Console.ReadLine().ToLower();
            string wordToCorrect = Console.ReadLine();

            int index = wordToCorrect.IndexOf(sample);

            while (index != -1)
            {
                wordToCorrect = wordToCorrect.Remove(index, sample.Length);

                index = wordToCorrect.IndexOf(sample);
            }

            Console.WriteLine(wordToCorrect);
        }
    }
}
