using System;
using System.Collections.Generic;
using System.Linq;

namespace _208.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> employeeList = new Dictionary<string, List<string>>();

            string[] newEntry;

            while ((newEntry = Console.ReadLine().Split(" -> "))[0] != "End")
            {
                string companyName = newEntry[0];
                string employeeID = newEntry[1];

                if (!employeeList.ContainsKey(companyName))
                {
                    employeeList.Add(companyName, new List<string>());
                    employeeList[companyName].Add(employeeID);

                }
                else
                {
                    if (!employeeList[companyName].Contains(employeeID))
                    {
                        employeeList[companyName].Add(employeeID);
                    }
                }
            }

            foreach (var company in employeeList.OrderBy(c => c.Key))
            {
                Console.WriteLine(company.Key);
                foreach (var employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
