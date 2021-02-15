using System;
using System.Collections.Generic;
using System.Linq;

namespace _22.TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine());
            List<int> liftOccupacy = Console.ReadLine()
                                        .Split()
                                        .Select(int.Parse)
                                        .ToList();
            int emptySpaces = 0;

            for (int i = 0; i < liftOccupacy.Count; i++)
            {
                if (liftOccupacy[i] >= 4)
                {
                    continue;
                }
                else
                {
                    emptySpaces += 4 - liftOccupacy[i];
                }
            }

            while (emptySpaces > 0 && peopleWaiting > 0)
            {
                for (int i = 0; i < liftOccupacy.Count; i++)
                {
                    int emptySpacesInCabin = 4 - liftOccupacy[i];
                    if (emptySpaces > 0)
                    {
                        while (liftOccupacy[i] < 4)
                        {
                            liftOccupacy[i]++;
                            peopleWaiting--;
                            emptySpaces--;

                            if (peopleWaiting == 0 || emptySpaces == 0)
                            {
                                break;
                            }
                        }
                        if (peopleWaiting == 0 || emptySpaces == 0)
                        {
                            break;
                        }
                    }
                }
            }

            if (peopleWaiting == 0 && emptySpaces > 0)
            {
                Console.WriteLine($"The lift has empty spots!{Environment.NewLine}{string.Join(" ", liftOccupacy)}");
            }
            else if (peopleWaiting == 0 && emptySpaces == 0)
            {
                Console.WriteLine(string.Join(" ", liftOccupacy));
            }
            else if (peopleWaiting > 0 && emptySpaces == 0)
            {
                Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!{Environment.NewLine}{string.Join(" ", liftOccupacy)}");
            }
        }
    }
}
