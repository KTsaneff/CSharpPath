using System;
using System.Collections.Generic;
using System.Linq;

namespace _106.Student2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentsList = new List<Student>();
            string listEntry;

            while ((listEntry = Console.ReadLine()) != "end")
            {
                string[] dataArr = listEntry.Split();

                string firstName = dataArr[0];
                string lastName = dataArr[1];
                int age = int.Parse(dataArr[2]);
                string hometown = dataArr[3];

                Student newEntry = new Student(firstName, lastName, age, hometown);

                Student student = studentsList.FirstOrDefault(s => s.FirstName == firstName
                                                                && s.LastName == lastName);

                if (student == null)
                {
                    studentsList.Add(new Student(firstName, lastName, age, hometown));
                }
                else
                {
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.Hometown = hometown;
                }
            }

            string city = Console.ReadLine();

            Student[] localStudents = studentsList.Where(x => x.Hometown == city).ToArray();
            foreach (Student student in localStudents)
            {
                Console.WriteLine(student);
            }
        }

        
    }

    class Student
    {
        public Student(string firstName, string lastName, int age, string hometown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Hometown = hometown;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int  Age { get; set; }
        public string Hometown { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old.";
        }
    }
}
