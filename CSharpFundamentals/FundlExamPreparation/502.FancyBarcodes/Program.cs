﻿using System;
using System.Text.RegularExpressions;

namespace _502.FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"@\#+[A-Z][A-Za-z0-9]{4,}[A-Z]@\#+";
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string currBarcode = Console.ReadLine();
                Match match = Regex.Match(currBarcode, pattern);

                if (match.Success)
                {
                    string compare = match.Value;
                    string temp = string.Empty;

                    for (int j = 0; j < compare.Length; j++)
                    {
                        if (char.IsDigit(compare[j]))
                        {
                            temp += compare[j];
                        }
                    }

                    if (temp == "")
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {temp}");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
