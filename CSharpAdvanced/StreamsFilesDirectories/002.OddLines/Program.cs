using System;
using System.IO;

namespace _002.OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../input.txt"))
            {
                string currRow = reader.ReadLine();
                int row = 0;

                using (StreamWriter writer = new StreamWriter("../../../output.txt"))
                {

                    while (currRow != null)
                    {
                        if (row % 2 == 1)
                        {
                            writer.WriteLine(currRow);
                        }
                        else
                        {
                            Console.WriteLine();
                        }

                        currRow = reader.ReadLine();
                        row++;
                    }
                }
            }
        }
    }
}
