using System;
using System.Linq;

namespace _106.LIS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mainArr = Console.ReadLine()
                                  .Split()
                                  .Select(int.Parse)
                                  .ToArray();

            int[] arrOfSolutions = new int[mainArr.Length];
            int[] prevSolutionPosition = new int[mainArr.Length];

            int maxSol = 0;
            int maxSolInd = 0;

            for (int currPos = 0; currPos < mainArr.Length-1; currPos++)
            {
                int solution = 1;
                int prevSolutionIndex = -1;
                int currNum = mainArr[currPos];

                for (int solutionIndex = 0; solutionIndex < currPos; solutionIndex++)
                {
                    int prevNum = mainArr[solutionIndex];
                    int prevSolution = arrOfSolutions[solutionIndex]; //предходното решение получава индекс 

                    if (currNum > prevNum && solution <= prevSolution)
                    {
                        solution = prevSolution + 1;
                        prevSolutionIndex = solutionIndex;
                    }
                }
                arrOfSolutions[currPos] = solution;
                prevSolutionPosition[currPos] = prevSolutionIndex;
            }
        }
    }
}
