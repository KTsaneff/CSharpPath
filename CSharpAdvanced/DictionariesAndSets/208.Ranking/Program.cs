using System;
using System.Collections.Generic;
using System.Linq;

namespace _208.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();

            string[] newContest = Console.ReadLine().Split(":");
            while (newContest[0] != "end of contests")
            {
                string contestName = newContest[0];
                string contestPass = newContest[1];

                if (!contests.ContainsKey(contestName))
                {
                    contests.Add(contestName, string.Empty);
                }
                contests[contestName] = contestPass;

                newContest = Console.ReadLine().Split(":");
            }

            Dictionary<string, Intern> interns = new Dictionary<string, Intern>();

            string[] newIntern = Console.ReadLine().Split("=>");
            while (newIntern[0] != "end of submissions")
            {
                string contestName = newIntern[0];
                string currPass = newIntern[1];
                string internName = newIntern[2];
                int pointsEarned = int.Parse(newIntern[3]);

                Intern currIntern = new Intern(internName, new Dictionary<string, int>(), 0);

                if (contests.ContainsKey(contestName) && contests[contestName] == currPass)
                {
                    if (!interns.ContainsKey(internName))
                    {
                        interns.Add(internName, currIntern);
                    }
                    if (!interns[internName].ContestName.ContainsKey(contestName))
                    {
                        interns[internName].ContestName.Add(contestName, 0);
                    }
                    if (interns[internName].ContestName.ContainsKey(contestName) && interns[internName].ContestName[contestName] < pointsEarned)
                    {
                        interns[internName].TotalScore -= interns[internName].ContestName[contestName];
                        interns[internName].TotalScore += pointsEarned;
                        interns[internName].ContestName[contestName] = pointsEarned;
                    }
                }

                newIntern = Console.ReadLine().Split("=>");
            }

            string bestCandidate = interns.OrderByDescending(x => x.Value.TotalScore).First().Value.Name;
            int bestScore = interns.OrderByDescending(x => x.Value.TotalScore).First().Value.TotalScore;

            Console.WriteLine($"Best candidate is {bestCandidate} with total {bestScore} points.");
            Console.WriteLine("Ranking: ");

            foreach (var candidate in interns.OrderBy(x => x.Key))
            {
                Console.WriteLine(candidate.Key);
                foreach (var module in candidate.Value.ContestName.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {module.Key } -> {module.Value}");
                }
            }
        }
    }
    class Intern
    {
        public Intern(string name, Dictionary<string, int> contestName, int totalScore)
        {
            Name = name;
            ContestName = contestName;
            TotalScore = totalScore;
        }

        public string Name { get; set; }
        public Dictionary<string, int> ContestName { get; set; }
        public int TotalScore { get; set; }
    }
}
