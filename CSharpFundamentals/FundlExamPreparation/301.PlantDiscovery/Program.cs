using System;

namespace _301.WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string plannedStops = Console.ReadLine();

            string manipulation;
            while ((manipulation = Console.ReadLine()) != "Travel")
            {
                string[] cmdArg = manipulation.Split(":");
                string change = cmdArg[0];

                if (change == "Add Stop")
                {
                    int index = int.Parse(cmdArg[1]);
                    if (index > -1 && index <= plannedStops.Length)
                    {
                        string givenSting = cmdArg[2];
                        plannedStops = plannedStops.Insert(index, givenSting);

                        Console.WriteLine(plannedStops);
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(plannedStops);
                        continue;
                    }
                }
                if (change == "Remove Stop")
                {
                    int stIndex = int.Parse(cmdArg[1]);
                    int endIndex = int.Parse(cmdArg[2]) + 1;

                    int tempIndex = 0;
                    if (stIndex > endIndex)
                    {
                        tempIndex = stIndex;
                        stIndex = endIndex;
                        endIndex = tempIndex;
                    }

                    if (stIndex > -1 && endIndex <= plannedStops.Length && stIndex != endIndex)
                    {
                        plannedStops = plannedStops.Remove(stIndex, endIndex - stIndex);
                        Console.WriteLine(plannedStops);
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(plannedStops);
                        continue;
                    }

                }
                if (change == "Switch")
                {
                    string oldString = cmdArg[1];
                    string newString = cmdArg[2];

                    if (plannedStops.Contains(oldString))
                    {
                        plannedStops = plannedStops.Replace(oldString, newString);
                        Console.WriteLine(plannedStops);
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(plannedStops);
                        continue;
                    }
                }
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {plannedStops}");
        }
    }
}
