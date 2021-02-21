using System;
using System.Collections.Generic;

namespace _205.HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> articleParts = new List<string>();
            string newEntry = Console.ReadLine();

            while (newEntry != "end of comments")
            {
                articleParts.Add(newEntry);

                newEntry = Console.ReadLine();
            }

            Console.WriteLine($"<h1>{Environment.NewLine}    {articleParts[0]}{Environment.NewLine}</h1>");
            Console.WriteLine($"<article>{Environment.NewLine}    {articleParts[1]}{Environment.NewLine}</article>");

            for (int i = 2; i < articleParts.Count; i++)
            {
                Console.WriteLine($"<div>{Environment.NewLine}    {articleParts[i]}{Environment.NewLine}</div>");
            }
        }
    }
}
