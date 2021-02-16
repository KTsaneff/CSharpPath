using System;
using System.Collections.Generic;
using System.Linq;

namespace _210.SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine()
                                           .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                           .ToList();
            string command;

            while ((command = Console.ReadLine()) != "course start")
            {
                string[] cmdArg = command.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string operation = cmdArg[0];
                string lessonTitle = cmdArg[1];
                int indexLesson = schedule.IndexOf(lessonTitle);
                string currExercise = lessonTitle + "-Exercise";

                if (operation == "Add")
                {
                    if (schedule.Contains(lessonTitle))
                    {
                        continue;
                    }
                    else
                    {
                        schedule.Add(lessonTitle);
                        continue;
                    }
                }
                if (operation == "Insert")
                {
                    int index = int.Parse(cmdArg[2]);

                    if (schedule.Contains(lessonTitle))
                    {
                        continue;
                    }
                    else
                    {
                        schedule.Insert(index, lessonTitle);
                        continue;
                    }
                }
                if (operation == "Remove")
                {
                    if (schedule.Contains(lessonTitle))
                    {
                        schedule.Remove(lessonTitle);

                        if (schedule.Contains(currExercise))
                        {
                            schedule.Remove(currExercise);
                        }

                        continue;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (operation == "Swap")
                {
                    string swapTitle = cmdArg[2];

                    if (schedule.Contains(lessonTitle) && schedule.Contains(swapTitle))
                    {
                        int indexSwap = schedule.IndexOf(swapTitle);
                        string swapExercise = swapTitle + "-Exercise";

                        schedule[indexLesson] = swapTitle;
                        schedule[indexSwap] = lessonTitle;

                        if (schedule.Contains(currExercise))
                        {
                            string temp = currExercise;
                            schedule.Remove(currExercise);
                            schedule.Insert(indexSwap + 1, temp);
                        }

                        if (schedule.Contains(swapExercise))
                        {
                            string temp = swapExercise;
                            schedule.Remove(swapExercise);
                            schedule.Insert(indexLesson + 1, temp);
                        }
                        continue;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (operation == "Exercise")
                {
                    if (schedule.Contains(lessonTitle))
                    {

                        if (schedule.Contains(currExercise))
                        {
                            continue;
                        }
                        else
                        {
                            schedule.Insert(indexLesson + 1, currExercise);
                            continue;
                        }
                    }
                    else
                    {
                        schedule.Add(lessonTitle);
                        schedule.Add(currExercise);
                    }
                }
            }

            for (int i = 1; i <= schedule.Count; i++)
            {
                Console.WriteLine($"{i}.{schedule[i - 1]}");
            }
        }
    }
}
