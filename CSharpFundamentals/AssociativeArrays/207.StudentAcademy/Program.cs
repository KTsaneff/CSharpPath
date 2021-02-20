using System;
using System.Collections.Generic;
using System.Linq;

namespace _207.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> gradeCollection = new Dictionary<string, List<double>>();
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!gradeCollection.ContainsKey(name))
                {
                    gradeCollection.Add(name, new List<double>());
                }
                gradeCollection[name].Add(grade);
            }

            Dictionary<string, double> gradedStudents = new Dictionary<string, double>();

            foreach (var student in gradeCollection)
            {
                double avGrade = student.Value.Average();
                if (avGrade >= 4.50)
                {
                    gradedStudents.Add(student.Key, avGrade);
                }
            }

            foreach (var item in gradedStudents.OrderByDescending(g => g.Value))
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}
