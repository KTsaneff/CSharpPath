using System;

namespace _02.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            Grade(grade);
        }

        private static void Grade(double grade)
        {
            string gradeToString = string.Empty;

            if (grade >= 2.00 && grade < 3.00)
            {
                gradeToString = "Fail";
            }
            if (grade >= 3.00 && grade < 3.50)
            {
                gradeToString = "Poor";
            }
            if (grade >= 3.50 && grade < 4.50)
            {
                gradeToString = "Good";
            }
            if (grade >= 4.50 && grade < 5.50)
            {
                gradeToString = "Very good";
            }
            if (grade >= 5.50 && grade < 6.00)
            {
                gradeToString = "Excellent";
            }

            Console.WriteLine(gradeToString);
        }
    }
}
