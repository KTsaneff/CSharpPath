using System;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] trainArr = new int[wagons];

            for (int i = 0; i < wagons; i++)
            {
                trainArr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(" ", trainArr));
            Console.WriteLine(trainArr.Sum());
        }
    }
}
