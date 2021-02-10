using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string reverse = "";
            string password = Console.ReadLine();
            char[] cArray = username.ToCharArray();
            int blockCouner = 1;

            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }


            while (password != reverse)
            {
                if (blockCouner >= 4)
                {
                    break;
                }
                Console.WriteLine($"Incorrect password. Try again.");
                password = Console.ReadLine();
                blockCouner++;
            }

            if (blockCouner < 4)
            {
                Console.WriteLine($"User {username} logged in.");
            }
            else
            {
                Console.WriteLine($"User {username} blocked!");
            }
        }
    }
}
