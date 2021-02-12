﻿using System;

namespace _01.DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            while (input != "END")
            {
                string dataType = String.Empty;

                try
                {
                    int number = int.Parse(input);
                    dataType = "integer";
                }
                catch (FormatException)
                {
                    try
                    {
                        double number = double.Parse(input);
                        dataType = "floating point";
                    }
                    catch (FormatException)
                    {
                        try
                        {
                            char number = char.Parse(input);
                            dataType = "character";
                        }
                        catch (FormatException)
                        {
                            try
                            {
                                bool number = bool.Parse(input);
                                dataType = "boolean";
                            }
                            catch (FormatException)
                            {
                                dataType = "string";
                            }
                        }
                    }
                }
                Console.WriteLine($"{input} is {dataType} type");
                input = Console.ReadLine();
            }
        }
    }
}
