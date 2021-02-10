using System;

namespace Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string message = String.Empty;

            while (input > 0)
            {
                int digit = int.Parse(Console.ReadLine());
                if (digit == 0)
                {
                    message += " ";
                    input--;
                    continue;
                }
                int lenght = digit.ToString().Length;
                int mainDigit = digit % 10;
                int offset = (mainDigit - 2) * 3;

                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset += 1;
                }

                int letterIndex = offset + lenght - 1;
                message += (char)(97 + letterIndex);
                input--;
            }

            Console.WriteLine(message);
        }
    }
}
