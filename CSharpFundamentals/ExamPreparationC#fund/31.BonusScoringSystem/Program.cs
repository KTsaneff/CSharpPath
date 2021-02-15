using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace _31.BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());
            double lectureCount = double.Parse(Console.ReadLine());
            double additionalBonus = double.Parse(Console.ReadLine());
            double maxBonus = 0;
            double maxAttendance = 0;

            for (int i = 0; i < studentCount; i++)
            {
                double attendances = double.Parse(Console.ReadLine());
                double currBonus = (attendances/lectureCount)*(5+additionalBonus);

                if (currBonus > maxBonus)
                {
                    maxBonus =currBonus;
                    maxAttendance = attendances;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Round(maxBonus, 0, MidpointRounding.AwayFromZero)}.");
            Console.WriteLine($"The student has attended {maxAttendance:f0} lectures.");
        }
    }
}
