using System;
using System.Collections.Generic;
using System.Linq;

namespace _102.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < count; i++)
            {
                string[] newEntry = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currStudent = newEntry[0];
                decimal currMark = decimal.Parse(newEntry[1]);

                if (!students.ContainsKey(currStudent))
                {
                    students.Add(currStudent, new List<decimal>());
                }
                                    
                students[currStudent].Add(currMark);
            }

            foreach (var student in students)
            {
                Console.Write($"{student.Key} -> ");
                foreach (var mark in student.Value)
                {
                    Console.Write($"{mark:f2} ");
                }

                Console.Write($"(avg: {student.Value.Average():f2})");
                Console.WriteLine();
            }
        }
    }
}
