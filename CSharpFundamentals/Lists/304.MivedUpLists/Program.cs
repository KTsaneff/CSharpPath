using System;
using System.Collections.Generic;
using System.Linq;

namespace _304.MivedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lineOne = Console.ReadLine()
                                          .Split()
                                          .Select(int.Parse)
                                          .ToList();

            List<int> lineTwo = Console.ReadLine()
                                          .Split()
                                          .Select(int.Parse)
                                          .ToList();

            int outputListCount = Math.Min(lineOne.Count, lineTwo.Count);
            List<int> splitList = new List<int>(outputListCount);
            List<int> boarders = new List<int>(2);

            if (lineOne.Count > lineTwo.Count)
            {
                boarders.Add(lineOne[lineOne.Count - 2]);
                boarders.Add(lineOne[lineOne.Count - 1]);
                lineOne.RemoveAt(lineOne.Count - 1);
                lineOne.RemoveAt(lineOne.Count - 1);
            }
            else
            {
                boarders.Add(lineTwo[0]);
                boarders.Add(lineTwo[1]);
                lineTwo.RemoveAt(0);
                lineTwo.RemoveAt(0);
            }

            for (int i = 0; i < lineOne.Count; i++)
            {
                splitList.Add(lineOne[i]);
                splitList.Add(lineTwo[lineTwo.Count - 1-i]);
            }

            boarders.Sort();

            List<int> outputList = new List<int>();

            for (int i = 0; i < splitList.Count; i++)
            {
                if (splitList[i] > boarders[0] && splitList[i] < boarders[1])
                {
                    outputList.Add(splitList[i]);
                }
            }

            outputList.Sort();
            Console.WriteLine(string.Join(" ", outputList));
        }
    }
}
