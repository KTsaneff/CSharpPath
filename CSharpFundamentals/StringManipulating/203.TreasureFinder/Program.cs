using System;
using System.Linq;
using System.Text;

namespace _203.TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] decodeKey = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

            string newEntry;
            while ((newEntry = Console.ReadLine()) != "find")
            {
                StringBuilder sb = new StringBuilder();
                string resource = string.Empty;
                string coordinates = string.Empty;
                
                int counter = 0;
                for (int i = 0; i < newEntry.Length; i++)
                {
                    char temp = (char)(newEntry[i] - decodeKey[counter]);
                    sb.Append(temp);
                    
                    counter++;
                    if (counter >= decodeKey.Length)
                    {
                        counter = 0;
                    }
                }

                string[] newArray = sb.ToString().Split("&").ToArray();

                resource = newArray[1];

                int start = newArray[2].IndexOf('<');
                int end = newArray[2].IndexOf('>');
                coordinates = newArray[2].Substring(start +1, end - start -1);

                Console.WriteLine($"Found {resource} at {coordinates}");
            }
        }
    }
}
