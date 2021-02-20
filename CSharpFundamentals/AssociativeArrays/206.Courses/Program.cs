using System;
using System.Collections.Generic;
using System.Linq;

namespace _206.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> mainRegister =new Dictionary<string, List<string>>();
            string[] newEntry;

            while ((newEntry = Console.ReadLine().Split(" : "))[0] != "end")
            {
                string courseName = newEntry[0];
                string studentName = newEntry[1];

                if (!mainRegister.ContainsKey(courseName))
                {
                    mainRegister.Add(courseName, new List<string>());
                }
                mainRegister[courseName].Add(studentName);
            }

            foreach (var course in mainRegister.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var item in course.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
