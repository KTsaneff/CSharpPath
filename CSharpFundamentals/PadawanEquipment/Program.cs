using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double sabrePrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double moneySpend = 0;
            double sabresNeeded = 1.10 * students;
            double robesNeeded = students;
            double beltsNeeded = students -(students / 6);

            moneySpend = sabrePrice * (Math.Ceiling(sabresNeeded)) + robePrice * robesNeeded + beltPrice * (Math.Floor(beltsNeeded));

            if (moneySpend <=budget)
            {
                Console.WriteLine($"The money is enough - it would cost {moneySpend:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {moneySpend-budget:f2}lv more.");
            }
        }
    }
}
