using System;
using System.Linq;

namespace _111.ArrManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToArray();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandArr = command.Split().ToArray();
                string firstOperation = commandArr[0];

                switch (firstOperation)
                {
                    case "exchange":
                        ExchangeInputArr(inputArr, commandArr);
                        break;
                    case "max":
                        IndexOfMaxEvenOddElement(inputArr, commandArr);
                        break;
                    case "min":
                        IndexOfMinEvenOddElement(inputArr, commandArr);
                        break;
                    case "first":
                        FirstCountElements(inputArr, commandArr);
                        break;
                    case "last":
                        LastCountElements(inputArr, commandArr);
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", inputArr)}]");
        }

        private static void LastCountElements(int[] inputArr, string[] commandArr)
        {
            string secondOperation = commandArr[2].ToString();
            int limit = int.Parse(commandArr[1]);

            if (limit >= 0 && limit <= inputArr.Length)
            {
                int counter = 0;
                string output = string.Empty;

                switch (secondOperation)
                {
                    case "even":

                        for (int i = inputArr.Length - 1; i >= 0; i--)
                        {
                            if (inputArr[i] % 2 == 0)
                            {
                                counter++;
                                output += inputArr[i].ToString();
                            }

                            if (counter == limit)
                            {
                                break;
                            }
                        }

                        char[] charArray = output.ToCharArray();
                        Array.Reverse(charArray);
                        Console.WriteLine($"[{string.Join(", ", charArray)}]");
                        break;
                    
                    case "odd":

                        for (int i = inputArr.Length - 1; i >= 0; i--)
                        {
                            if (inputArr[i] % 2 != 0)
                            {
                                counter++;
                                output += inputArr[i].ToString();
                            }

                            if (counter == limit)
                            {
                                break;
                            }
                        }

                        char[] char1Array = output.ToCharArray();
                        Array.Reverse(char1Array);
                        Console.WriteLine($"[{string.Join(", ", char1Array)}]");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid Count");
            }
        }

        private static void FirstCountElements(int[] inputArr, string[] commandArr)
        {
            string secondOperation = commandArr[2].ToString();
            int limit = int.Parse(commandArr[1]);

            if (limit > 0 && limit <= inputArr.Length)
            {
                string output = string.Empty;
                int counter = 0;

                switch (secondOperation)
                {
                    case "even":

                        for (int i = 0; i < inputArr.Length; i++)
                        {
                            if (inputArr[i] % 2 == 0)
                            {
                                counter++;
                                output += inputArr[i].ToString();
                            }

                            if (counter == limit)
                            {
                                break;
                            }
                        }

                        char[] charArray = output.ToCharArray();
                        Console.WriteLine($"[{string.Join(", ", charArray)}]");
                        break;

                    case "odd":
                        for (int i = 0; i < inputArr.Length; i++)
                        {
                            if (inputArr[i] % 2 != 0)
                            {
                                counter++;
                                output += inputArr[i].ToString();
                            }

                            if (counter == limit)
                            {
                                break;
                            }
                        }

                        char[] char1Array = output.ToCharArray();
                        Console.WriteLine($"[{string.Join(", ", char1Array)}]");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid count");
            }

        }

        private static void IndexOfMinEvenOddElement(int[] inputArr, string[] commandArr)
        {
            switch (commandArr[1])
            {
                case "even":
                    PrintMinEvenPosition(inputArr);
                    break;
                case "odd":
                    PrintMinOddPosition(inputArr);
                    break;
            }
        }

        private static void PrintMinOddPosition(int[] inputArr)
        {
            int minOddPosition = -1;
            int minOddValue = Int32.MaxValue;

            for (int i = 0; i < inputArr.Length; i++)
            {
                if (inputArr[i] % 2 != 0 && inputArr[i] <= minOddValue)
                {
                    minOddPosition = i;
                    minOddValue = inputArr[i];
                }
            }

            if (minOddPosition == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(minOddPosition);
            }
        }

        private static void PrintMinEvenPosition(int[] inputArr)
        {
            int minEvenPosition = -1;
            int minEvenValue = Int32.MaxValue;

            for (int i = 0; i < inputArr.Length; i++)
            {
                if (inputArr[i] % 2 == 0 && inputArr[i] <= minEvenValue)
                {
                    minEvenPosition = i;
                    minEvenValue = inputArr[i];
                }

            }

            if (minEvenPosition == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(minEvenPosition);
            }
        }

        private static void IndexOfMaxEvenOddElement(int[] inputArr, string[] commandArr)
        {
            switch (commandArr[1])
            {
                case "even":
                    PrintMaxEvenPosition(inputArr);
                    break;
                case "odd":
                    PrintMaxOddPosition(inputArr);
                    break;
            }
        }

        private static void PrintMaxOddPosition(int[] inputArr)
        {
            int maxOddPosition = -1;
            int maxOddValue = Int32.MinValue;

            for (int i = 0; i < inputArr.Length; i++)
            {
                if (inputArr[i] % 2 != 0 && inputArr[i] >= maxOddValue)
                {
                    maxOddPosition = i;
                    maxOddValue = inputArr[i];
                }
            }

            if (maxOddPosition == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(maxOddPosition);
            }
        }

        private static void PrintMaxEvenPosition(int[] inputArr)
        {
            int maxEvenPosition = -1;
            int maxEvenValue = Int32.MinValue;

            for (int i = 0; i < inputArr.Length; i++)
            {
                if (inputArr[i] % 2 == 0 && inputArr[i] >= maxEvenValue)
                {
                    maxEvenPosition = i;
                    maxEvenValue = inputArr[i];
                }
            }

            if (maxEvenPosition == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(maxEvenPosition);
            }
        }

        private static void ExchangeInputArr(int[] inputArr, string[] commandArr)
        {
            int index = int.Parse(commandArr[1]);

            if (index < 0 || index > inputArr.Length)
            {
                Console.WriteLine($"Invalid index");
            }
            else
            {
                int[] secPart = new int[inputArr.Length - index - 1];

                for (int i = 0; i < secPart.Length; i++)
                {
                    secPart[i] = inputArr[i + index + 1];
                }

                int[] firstPart = new int[index + 1];

                for (int i = 0; i < firstPart.Length; i++)
                {
                    firstPart[i] = inputArr[i];
                }

                int counter = 0;

                for (int i = 0; i < inputArr.Length; i++)
                {
                    

                    if (i < secPart.Length)
                    {
                        inputArr[i] = secPart[i];
                    }
                    else
                    {
                        inputArr[i] = firstPart[counter];
                        counter++;
                    }
                }
            }
        }
    }
}
