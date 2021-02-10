using System;

namespace Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string result = "";

            if (age >= 0 && age <= 2)
            {
                result +="baby";
            }
            if (age >= 3 && age <= 13)
            {
                result +="child";
            }
            if (age >= 14 && age <= 19)
            {
                result +="teenager";
            }
            if (age >= 20 && age <= 65)
            {
                result +="adult";
            }
            if (age > 65)
            {
                result +="elder";
            }

            Console.WriteLine(result);
        }
    }
}
