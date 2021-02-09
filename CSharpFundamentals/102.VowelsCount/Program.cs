using System;

namespace _102.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            int result = CountVowels(input);

            Console.WriteLine(result);
        }

        public static int CountVowels(string input)
        {
            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char curentChar = input[i];

                if (curentChar == 'a' || curentChar == 'e' || curentChar == 'i' || curentChar == 'o' || curentChar == 'u')
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
