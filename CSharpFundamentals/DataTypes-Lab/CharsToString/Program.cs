using System;

namespace CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char input;

            string text = String.Empty;

            for (int i = 0; i < 3; i++)
            {
                input = Convert.ToChar(Console.ReadLine());
                text += input;
            }

           

            Console.WriteLine(text);
        }
    }
}
