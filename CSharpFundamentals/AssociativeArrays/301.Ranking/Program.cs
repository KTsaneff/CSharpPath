using System;
using System.Collections.Generic;
using System.Linq;

namespace _301.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestsPassList = new Dictionary<string, string>();
            SortedDictionary<string, Dictionary<string, int>> participationList = new SortedDictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> pointRegistry = new Dictionary<string, int>();

            int bestScore = int.MinValue;
            string bestUser = string.Empty;

            string contestInput = Console.ReadLine();
            while (contestInput != "end of contests")
            {
                string[] newEntry = contestInput.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string newContest = newEntry[0];
                string newPassword = newEntry[1];

                if (!contestsPassList.ContainsKey(newContest))
                {
                    contestsPassList.Add(newContest, string.Empty);
                }
                contestsPassList[newContest] = newPassword;

                contestInput = Console.ReadLine();
            }

            string contestData = Console.ReadLine();
            while (contestData != "end of submissions")
            {
                string[] dataSplit = contestData.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contestRequest = dataSplit[0];
                string passwordRequest = dataSplit[1];
                string user = dataSplit[2];
                int points = int.Parse(dataSplit[3]);

                if (!contestsPassList.ContainsKey(contestRequest) || !contestsPassList.ContainsValue(passwordRequest))
                {
                    contestData = Console.ReadLine();
                    continue;
                }

                if (!participationList.ContainsKey(user))
                {
                    participationList.Add(user, new Dictionary<string, int>());
                    participationList[user].Add(contestRequest, points);
                    pointRegistry.Add(user, points);
                }

                if (participationList.ContainsKey(user) && participationList[user].ContainsKey(contestRequest) && participationList[user][contestRequest] < points)
                {
                    pointRegistry[user] -= participationList[user][contestRequest];
                    participationList[user][contestRequest] = points;
                    pointRegistry[user] += points;
                }

                if (participationList.ContainsKey(user) && !participationList[user].ContainsKey(contestRequest))
                {
                    participationList[user].Add(contestRequest, points);
                    pointRegistry[user] += points;
                }


                contestData = Console.ReadLine();
            }

            foreach (var points in pointRegistry)
            {
                if (points.Value > bestScore)
                {
                    bestScore = points.Value;
                    bestUser = points.Key;
                }
            }

            Console.WriteLine($"Best candidate is {bestUser} with total {bestScore} points.");
            Console.WriteLine("Ranking: ");

            foreach (var user in participationList)
            {
                Console.WriteLine(user.Key);
                foreach (var item in user.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }
    }
}
