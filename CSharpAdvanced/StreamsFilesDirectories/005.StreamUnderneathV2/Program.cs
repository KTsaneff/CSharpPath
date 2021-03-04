using System;
using System.IO;

namespace _005.StreamUnderneathV2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream stream = new FileStream("../../../students.txt", FileMode.Open))
            {
                byte[] buffer = new byte[100];
                Console.WriteLine($"Stream Position: {stream.Position}");
                int times = 0;

                for (int i = 0; i < stream.Length / buffer.Length; i++)
                {
                    times++;
                    stream.Read(buffer, 0, buffer.Length);

                    using (FileStream writerStream = new FileStream($"../../../students-{i}.txt", FileMode.Create, FileAccess.Write))
                    {
                        writerStream.Write(buffer, 0, buffer.Length);
                    }
                }
                Console.WriteLine(times);
                Console.WriteLine($"Stream Position: {stream.Position}");

            }
        }
    }
}
