using System;

namespace _004.TextFiltering
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordsToDelete = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string textToCorrect = Console.ReadLine();

            foreach (var word in wordsToDelete)
            {
                string replaceWith = new string('*', word.Length);
                textToCorrect = textToCorrect.Replace(word, replaceWith);
            }

            Console.WriteLine(textToCorrect);
        }
    }
}
