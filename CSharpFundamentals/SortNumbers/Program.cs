using System;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int pos1 = 0;
            int pos2 = 0;
            int pos3 = 0;

            if (num1 >= num2 && num1 >= num3)
            {
                pos1 = num1;
                if (num2 >= num3)
                {
                    pos2 = num2;
                    pos3 = num3;
                }
                else
                {
                    pos2 = num3;
                    pos3 = num2;
                }
            }
            if (num2 >= num1 && num2 >= num3)
            {
                pos1 = num2;
                if (num1 >= num3)
                {
                    pos2 = num1;
                    pos3 = num3;
                }
                else
                {
                    pos2 = num3;
                    pos3 = num1;
                }
            }
            if (num3 >= num1 && num3 >= num2)
            {
                pos1 = num3;
                if (num1 >= num2)
                {
                    pos2 = num1;
                    pos3 = num2;
                }
                else
                {
                    pos2 = num2;
                    pos3 = num1;
                }
            }

            Console.WriteLine(pos1);
            Console.WriteLine(pos2);
            Console.WriteLine(pos3);
        }
    }
}
