using System;
using System.Collections.Generic;

namespace _205.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> ownerRegCar = new Dictionary<string, string>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] newApplication = Console.ReadLine().Split();
                string request = newApplication[0];
                string user = newApplication[1];

                if (request == "register")
                {
                    string licencsePlate = newApplication[2];

                    if (ownerRegCar.ContainsKey(user))
                    {

                        Console.WriteLine($"ERROR: already registered with plate number {ownerRegCar[user]}");

                    }
                    else
                    {
                        ownerRegCar.Add(user, licencsePlate);
                        Console.WriteLine($"{user} registered {licencsePlate} successfully");
                    }
                }
                else if (request == "unregister")
                {
                    if (ownerRegCar.ContainsKey(user))
                    {
                        Console.WriteLine($"{user} unregistered successfully");
                        ownerRegCar.Remove(user);
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                }
            }

            foreach (var registeredUser in ownerRegCar)
            {
                Console.WriteLine($"{registeredUser.Key} => {registeredUser.Value}");
            }
        }
    }
}
