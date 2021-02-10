using System;
using System.Dynamic;
using System.Linq;

namespace LastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int lastDigit = input % 10;

            string output = String.Empty;

            if (lastDigit>=0)
            {
                switch (lastDigit)
                {
                    case 0:
                        output = "zero";
                        break;
                    case 1:
                        output = "one";
                        break;
                    case 2:
                        output = "two";
                        break;
                    case 3:
                        output = "three";
                        break;
                    case 4:
                        output = "four";
                        break;
                    case 5:
                        output = "five";
                        break;
                    case 6:
                        output = "six";
                        break;
                    case 7:
                        output = "seven";
                        break;
                    case 8:
                        output = "eight";
                        break;
                    case 9:
                        output = "nine";
                        break;
                }
            }
            else
            {
                switch (lastDigit)
                {
                    case -1:
                        output = "minus one";
                        break;
                    case -2:
                        output = "minus two";
                        break;
                    case -3:
                        output = "minus three";
                        break;
                    case -4:
                        output = "minus four";
                        break;
                    case - 5:
                        output = "minus five";
                        break;
                    case -6:
                        output = "minus six";
                        break;
                    case -7:
                        output = "minus seven";
                        break;
                    case -8:
                        output = "minus eight";
                        break;
                    case -9:
                        output = "minus nine";
                        break;
                }
            }

            Console.WriteLine(output);
        }
    }
}
