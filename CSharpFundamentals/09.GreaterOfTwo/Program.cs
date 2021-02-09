using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _09.GreaterOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            string output = FindGreaterValue(type);
            Console.WriteLine(output);
        }

        private static string FindGreaterValue(string type)
        {
            string[] arr = new string[2];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine();
            }

            string result = arr.Max().ToString();
            return result;
        }
    }
}
