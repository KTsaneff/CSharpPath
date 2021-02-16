﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _107.ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .Select(int.Parse)
                                        .ToList();

            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            bool isManipulated = false;

            while (command[0].ToUpper() != "END")
            {
                switch (command[0].ToUpper())
                {
                    case "ADD":
                        numbers.Add(int.Parse(command[1]));
                        isManipulated = true;
                        break;
                    case "REMOVE":
                        numbers.Remove(int.Parse(command[1]));
                        isManipulated = true;
                        break;
                    case "REMOVEAT":
                        numbers.RemoveAt(int.Parse(command[1]));
                        isManipulated = true;
                        break;
                    case "INSERT":
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        isManipulated = true;
                        break;
                    case "CONTAINS":
                        Console.WriteLine(numbers.Contains(int.Parse(command[1])) ? "Yes" : "No such number");
                        break;
                    case "PRINTEVEN":
                        Console.WriteLine(string.Join(" ", numbers
                                .Where(n => n % 2 == 0)));
                        break;
                    case "PRINTODD":
                        Console.WriteLine(string.Join(" ", numbers
                                .Where(n => n % 2 !=0)));
                        break;
                    case "GETSUM":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "FILTER":
                        string result = string.Empty;
                        
                        switch (command[1])
                        {
                            case "<":
                                result = string.Join(" ", numbers
                                                .Where(n => n<int.Parse(command[2])));
                                break;
                            case ">":
                                result = string.Join(" ", numbers
                                                .Where(n => n > int.Parse(command[2])));
                                break;
                            case "<=":
                                result = string.Join(" ", numbers
                                                .Where(n => n <= int.Parse(command[2])));
                                break;
                            case ">=":
                                result = string.Join(" ", numbers
                                                .Where(n => n >= int.Parse(command[2])));
                                break;
                        }

                        Console.WriteLine(result);
                        break;
                }

                command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }


            if (isManipulated)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
