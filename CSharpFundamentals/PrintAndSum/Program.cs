using System;

namespace PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            string row = "";
            int sum = 0;

            for (int i = start; i <= end; i++)
            {
                row += i.ToString()+" ";
                sum += i;

            }

            Console.WriteLine(row);
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
