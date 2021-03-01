using System;
using System.Collections.Generic;
using System.Linq;

namespace _107.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipInvitations = new HashSet<string>();
            HashSet<string> regularInvitations = new HashSet<string>();

            string newEntry = Console.ReadLine();
            while (newEntry != "PARTY")
            {
                if (newEntry[0] >=48 && newEntry[0] <= 57)
                {
                    vipInvitations.Add(newEntry);
                }
                else
                {
                    regularInvitations.Add(newEntry);
                }
                newEntry = Console.ReadLine();
            }

            string arrival = Console.ReadLine();
            while (arrival != "END")
            {
                if (arrival[0] >= 48 && arrival[0] <= 57)
                {
                    vipInvitations.Remove(arrival);
                }
                else
                {
                    regularInvitations.Remove(arrival);
                }
                arrival = Console.ReadLine();
            }

            Console.WriteLine(vipInvitations.Count + regularInvitations.Count);

            foreach (var guest in vipInvitations)
            {
                Console.WriteLine(guest);
            }
            foreach (var guest in regularInvitations)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
