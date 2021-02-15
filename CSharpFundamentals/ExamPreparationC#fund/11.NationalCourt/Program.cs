using System;

namespace _11.NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] employeeEficiency = new int[3];
            int eficiencyPerHour = 0;

            for (int i = 0; i < 3; i++)
            {
                employeeEficiency[i] = int.Parse(Console.ReadLine());
                eficiencyPerHour += employeeEficiency[i];
            }

            int peopleCount = int.Parse(Console.ReadLine());
            int hoursNeeded = 0;

            while (peopleCount > 0)
            {
                hoursNeeded++;
                if (hoursNeeded % 4 == 0)
                {
                    continue;
                }
                peopleCount -= eficiencyPerHour;
            }

            Console.WriteLine($"Time needed: {hoursNeeded}h.");
        }
    }
}
