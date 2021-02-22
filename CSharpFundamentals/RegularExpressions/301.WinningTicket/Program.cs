using System;
using System.Text.RegularExpressions;

namespace _301.WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i++)
            {
                string currTicket = input[i];
                if (currTicket.Length == 20)
                {
                    string firstHalf = currTicket.Substring(0, 10);
                    string secHalf = currTicket.Substring(10, 10);

                    string winningPattern = @"([@]{6,10}|[#]{6,10}|[$]{6,10}|[\^]{6,10})";

                    Regex regex = new Regex(winningPattern);

                    Match firstMatch = regex.Match(firstHalf);
                    Match secMatch = regex.Match(secHalf);

                    firstHalf = firstMatch.ToString();
                    secHalf = secMatch.ToString();

                    if (firstMatch.Success && secMatch.Success && firstHalf[0].ToString() == secHalf[0].ToString())
                    {
                        if (firstHalf.Length == secHalf.Length)
                        {
                            if (firstHalf.Length == 10)
                            {
                                Console.WriteLine($"ticket \"{currTicket}\" - {firstHalf.Length}{firstHalf[0]} Jackpot!");
                            }
                            else
                            {
                                Console.WriteLine($"ticket \"{currTicket}\" - {firstHalf.Length}{firstHalf[0]}");
                            }
                        }
                        else
                        {
                            int lessLength = firstHalf.Length;
                            string symbol = firstHalf[0].ToString();
                            
                            if (secHalf.Length < firstHalf.Length)
                            {
                                lessLength = secHalf.Length;
                            }

                            Console.WriteLine($"ticket \"{currTicket}\" - {lessLength}{symbol}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{currTicket}\" - no match");
                        continue;
                    }

                    

                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}
