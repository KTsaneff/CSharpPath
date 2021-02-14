using System;
using System.Linq;

namespace _10.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {

            int fieldSize = int.Parse(Console.ReadLine());


            int[] ladyBugStartingPos = Console.ReadLine()
                                            .Split()
                                            .Select(int.Parse)
                                            .ToArray();

            int[] cellsArray = new int[fieldSize];

            for (int i = 0; i < cellsArray.Length; i++)
            {
                for (int j = 0; j < ladyBugStartingPos.Length; j++)
                {
                    if (ladyBugStartingPos[j] == i)
                    {
                        cellsArray[i] = 1;
                    }
                }
            }

            string flightCommand = string.Empty;

            while ((flightCommand = Console.ReadLine()) != "end")
            {
                string[] commArr = flightCommand.Split().ToArray();
                int position = int.Parse(commArr[0]);
                int flightLength = int.Parse(commArr[2]);

                switch (commArr[1].ToString())
                {
                    case "right":
                        if (flightLength == 0) // if the fligh length equals to zero
                        {
                            break;
                        }
                        else if (position >= 0 && position <= cellsArray.Length - 1 && cellsArray[position] == 1) // if the flight length is not zero & the position is in limits and                                                                                        there is a ladybug on position
                        {
                            while (position + flightLength <= cellsArray.Length - 1 && position + flightLength >= 0) // if the position after flight is in limits
                            {
                                if (cellsArray[position + flightLength] == 0) // if there is an empty space for landing
                                {
                                    cellsArray[position + flightLength] = 1; // landing
                                    cellsArray[position] = 0; // starting position is empty
                                    break;
                                }
                                else if (cellsArray[position + flightLength] == 1) // if the landing spot is occupied
                                {
                                    flightLength+=flightLength; //flight length is extended 
                                    cellsArray[position] = 0; // starting position is empty
                                }
                            }

                            if (position + flightLength > cellsArray.Length - 1 || position + flightLength < 0)
                            {
                                cellsArray[position] = 0;
                                continue;
                            }
                        }
                        else //position out of limits or no ladybug on position
                        {
                            continue;
                        }

                        break;


                    case "left":
                        if (flightLength == 0)
                        {
                            break;
                        }
                        else if (position >= 0 && position <= cellsArray.Length - 1 && cellsArray[position] == 1)
                        {
                            while (position - flightLength >= 0 && position - flightLength <= cellsArray.Length-1)
                            {
                                if (cellsArray[position - flightLength] == 0)
                                {
                                    cellsArray[position - flightLength] = 1;
                                    cellsArray[position] = 0;
                                    break;
                                }
                                else if (cellsArray[position - flightLength] == 1)
                                {
                                    flightLength+=flightLength;
                                    cellsArray[position] = 0;
                                }
                            }
                            if (position - flightLength < 0 || position - flightLength > cellsArray.Length-1)
                            {
                                cellsArray[position] = 0;
                                continue;
                            }
                        }
                        else
                        {
                            continue;
                        }
                        break;
                }
            }

            Console.WriteLine($"{string.Join(" ", cellsArray)}");
        }
    }
}

