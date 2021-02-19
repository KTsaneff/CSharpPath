using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _207.OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> refference = new List<Person>();
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArg = command.Split();

                string name = cmdArg[0];
                int iD = int.Parse(cmdArg[1]);
                int age = int.Parse(cmdArg[2]);

                Person person = new Person(name, iD, age);
                refference.Add(person);
            }

            refference = refference.OrderBy(x => x.Age).ToList();
            foreach (Person position in refference)
            {
                Console.WriteLine(position);
            }
        }
    }

    class Person
    {
        public Person(string name, int iD, int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }

        public string Name { get; set; }
        public int ID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}
