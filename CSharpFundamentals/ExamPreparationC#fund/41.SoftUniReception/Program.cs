using System;

namespace _41.SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] employeeEfiiciency = new int[3];
            for (int i = 0; i < employeeEfiiciency.Length; i++)
            {
                employeeEfiiciency[i] = int.Parse(Console.ReadLine());
            }

            int studentsCount = int.Parse(Console.ReadLine());
            int hourCount = 0;

            while (studentsCount > 0)
            {
                hourCount++;

                if (hourCount % 4 == 0)
                {
                    continue;
                }

                for (int i = 0; i < employeeEfiiciency.Length; i++)
                {
                    studentsCount -= employeeEfiiciency[i];
                    if (studentsCount <= 0)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine($"Time needed: {hourCount}h.");
        }
    }
}
