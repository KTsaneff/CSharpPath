using System;
using System.Linq;

namespace _09.GreaterOfTwo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            string output = GetMax(type);
            Console.WriteLine(output);
        }

        private static string GetMax(string type)
        {
            string result = string.Empty;
            if (type == "string")
            {
                string[] arr = new string[2];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = Console.ReadLine();
                }

                result = arr.Max();
            }
            if (type =="char")
            {
                char[] arr = new char[2];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = Convert.ToChar(Console.ReadLine());
                }

                result = arr.Max().ToString();
            }
            if (type == "int")
            {
                int[] arr = new int[2];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
                result = arr.Max().ToString();
            }

            return result;
        }
    }
}
