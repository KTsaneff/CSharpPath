using System;
using System.Collections.Generic;
using System.Linq;

namespace _105.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string listEntry;

            while ((listEntry = Console.ReadLine()) != "end")
            {
                string[] dataArr = listEntry.Split();

                string firstName = dataArr[0];
                string lastName = dataArr[1];
                int age = int.Parse(dataArr[2]);
                string hometown = dataArr[3];

                Student student = new Student(firstName, lastName, age, hometown);
                students.Add(student);
            }

            string city = Console.ReadLine();

            Student[] localStudents = students.Where(x => x.HomeTown == city).ToArray();
            foreach (Student student in localStudents)
            {
                Console.WriteLine(student);
            }

        }
    }

    class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old.";
        }
    }
}
