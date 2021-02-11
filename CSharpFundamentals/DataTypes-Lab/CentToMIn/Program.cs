using System;

namespace CentToMIn
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            double years = centuries * 100;
            double days = centuries * 36524.22;
            double hours = Math.Floor(days) * 24;
            double minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years:f0} years = {Math.Floor(days):f0} days = {hours:f0} hours = {minutes:f0} minutes");
        }
    }
}
