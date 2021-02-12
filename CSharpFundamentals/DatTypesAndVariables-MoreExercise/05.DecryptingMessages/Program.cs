using System;

namespace _05.DecryptingMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());

            string message = String.Empty;

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                char letter = char.Parse(input);
                message += Convert.ToChar(letter+key);
            }
            Console.WriteLine(message);
        }
    }
}
