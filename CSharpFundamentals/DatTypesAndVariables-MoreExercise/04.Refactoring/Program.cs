using System;

namespace _04.Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit= int.Parse(Console.ReadLine());

            for (int i = 2; i <= limit; i++)
            {
                bool isPrime = true;
                
                for (int divider = 2; divider < i; divider++)
                {
                    if (i % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isPrime.ToString().ToLower()}");
            }

        }
    }
}
