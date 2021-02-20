using System;
using System.Collections.Generic;
using System.Linq;

namespace _210.SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>();
            Dictionary<string, int> sumbmissions = new Dictionary<string, int>();

            string input = Console.ReadLine();
            while (input != "exam finished")
            {
                string[] newEntry = input.Split("-");
                string user = newEntry[0];

                if (newEntry[1] != "banned")
                {
                    string language = newEntry[1];
                    int points = int.Parse(newEntry[2]);

                    if (!students.ContainsKey(user))
                    {
                        students.Add(user, points);
                    }
                    else
                    {
                        if (students[user] < points)
                        {
                            students[user] = points;
                        }
                    }

                    if (!sumbmissions.ContainsKey(language))
                    {
                        sumbmissions.Add(language, 0);
                    }
                    sumbmissions[language] += 1;
                }
                else
                {
                    students.Remove(user);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Results:");
            foreach (var currStudent in students.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{currStudent.Key} | {currStudent.Value}");
            }

            Console.WriteLine("Submissions:");
            foreach (var currSubmission in sumbmissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{currSubmission.Key} - {currSubmission.Value}");
            }
        }
    }
}
