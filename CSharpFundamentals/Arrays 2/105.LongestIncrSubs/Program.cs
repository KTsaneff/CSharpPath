using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;
using System.IO.Pipes;
using System.Linq;

namespace _105.LongestIncrSubs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mainArr = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToArray();

            int[] arrOfLengths = new int[mainArr.Length];
            int[] prevSolutions = new int[mainArr.Length];

            int maxSolution = 0;
            int maxSolutionIndex = 0;

            for (int current = 0; current < mainArr.Length; current++)
            {
                int solution = 1;
                int prevIndex = -1;
                int currentNum = mainArr[current];

                for (int solutionIndex = 0; solutionIndex < current; solutionIndex++)
                {
                    int prevNum = mainArr[solutionIndex]; // previeous number *3
                    int prevSolution = arrOfLengths[solutionIndex]; // previous solution *1

                    if (currentNum > prevNum && solution <= prevSolution) // if current number is greater than previous number & if current solution is smaller or equal to previous solution * 14>3 && 1<=1
                    {
                        solution = prevSolution + 1; //increase solution by 1
                        prevIndex = solutionIndex;
                    }
                }
                arrOfLengths[current] = solution;
                prevSolutions[current] = prevIndex;

                if (solution > maxSolution)
                {
                    maxSolution = solution;
                    maxSolutionIndex = current;
                }
            }

            int index = maxSolutionIndex;

            var result = new List<int>();

            while (index >-1)
            {
                int tempNum = mainArr[index];
                result.Add(tempNum);
                index = prevSolutions[index];
            }
            result.Reverse();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
