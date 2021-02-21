using System;
using System.Linq;
using System.Text;

namespace _105.MultiplyBigNum
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string longNum = Console.ReadLine().TrimStart('0');
            
            int num = int.Parse(Console.ReadLine());
            int temp = 0;

            if (num == 0 || longNum == "")
            {
                Console.WriteLine(0);
                return;
            }

            foreach (char ch in longNum.Reverse())
            {
                int digit = int.Parse(ch.ToString());
                int result = digit * num + temp;
                int digitLeft = result % 10;
                temp = result / 10;
                sb.Insert(0, digitLeft);
            }

            if (temp > 0)
            {
                sb.Insert(0, temp);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
