using System;
using System.IO;

namespace _007.Directories
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory("../../../Calisto");
            Directory.Delete("../../../Calisto");
        }
    }
}
