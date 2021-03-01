using System;

namespace _001.CustomHashSetImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomHashSet customSet = new CustomHashSet();

            for (int i = 0; i < 500; i++)
            {
                customSet.Add($"{i}{i}");
            }

            Console.WriteLine(customSet.Contains(""));
        }
    }
}
