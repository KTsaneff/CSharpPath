using System;
using System.Collections.Generic;
using System.Linq;

namespace _301.CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<Department> departments = new List<Department>();

            for (int i = 0; i < lines; i++)
            {
                string[] newEntry = Console.ReadLine().Split();

                string empName = newEntry[0];
                double empSalary = double.Parse(newEntry[1]);
                string departmentName = newEntry[2];

                if (!departments.Any(d => d.DepartmentName == departmentName))
                {
                    departments.Add(new Department(departmentName));
                }

                departments.Find(d => d.DepartmentName == departmentName).AddNewEmployee(empName, empSalary);
            }

            Department bestDepartment = departments.OrderByDescending(d => d.TotalSalaries / d.Employees.Count()).First();

            Console.WriteLine($"Highest Average Salary: {bestDepartment.DepartmentName}");
            foreach (var employee in bestDepartment.Employees.OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
            }
        }
    }

    class Employee
    {
        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public string Name { get; set; }
        public double Salary { get; set; }
    }
    class Department
    {
        public string DepartmentName { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public double TotalSalaries { get; set; }

        public void AddNewEmployee(string name, double salary)
        {
            TotalSalaries += salary;
            Employees.Add(new Employee(name, salary));
        }

        public Department(string departmentName)
        {
            DepartmentName = departmentName;
        }
    }
}
