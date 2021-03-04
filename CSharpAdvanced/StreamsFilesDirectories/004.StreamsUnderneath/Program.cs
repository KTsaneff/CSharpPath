using System;
using System.IO;

namespace _004.StreamsUnderneath
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream stream = new FileStream("../../../students.txt", FileMode.Open))
            {
                byte[] buffer = new byte[4096];
                Console.WriteLine($"Stream Position: {stream.Position}");
                int times = 0;

                for (int i = 0; i < stream.Length/buffer.Length; i++)
                {
                    times++;
                    stream.Read(buffer, 0, buffer.Length);

                    //Console.Write($"{(char)buffer[0]}{(char)buffer[1]}");

                }
                Console.WriteLine(times);
                Console.WriteLine($"Stream Position: {stream.Position}");

            }
        }
    }
}
