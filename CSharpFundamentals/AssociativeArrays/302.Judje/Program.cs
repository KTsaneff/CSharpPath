using System;
using System.Collections.Generic;
using System.Linq;

namespace _302.Judje
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> judgeStatistics = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> overallScore = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "no more time")
            {
                string[] newEntry = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string contest = newEntry[1];
                string user = newEntry[0];
                int result = int.Parse(newEntry[2]);

                if (!judgeStatistics.ContainsKey(contest))
                {
                    judgeStatistics.Add(contest, new Dictionary<string, int>());
                    judgeStatistics[contest].Add(user, result);
                }
                else
                {
                    if (!judgeStatistics[contest].ContainsKey(user))
                    {
                        judgeStatistics[contest].Add(user, result);
                    }
                    else
                    {
                        if (judgeStatistics[contest][user] < result)
                        {
                            judgeStatistics[contest][user] = result;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var diffContest in judgeStatistics)
            {
                Console.WriteLine($"{diffContest.Key}: {diffContest.Value.Count} participants");

                int counter = 1;
                foreach (var participant in diffContest.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{counter}. {participant.Key} <::> {participant.Value}");

                    counter++;
                }
            }

            Console.WriteLine("Individual standings:");

            foreach (var item in judgeStatistics)
            {
                foreach (var user in item.Value)
                {
                    if (!overallScore.ContainsKey(user.Key))
                    {
                        overallScore.Add(user.Key, user.Value);
                    }
                    else
                    {
                        overallScore[user.Key] += user.Value;
                    }
                }
            }

            int counterlast = 1;
            foreach (var line in overallScore.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{counterlast}. {line.Key} -> {line.Value}");

                counterlast++;
            }
        }
    }
}
