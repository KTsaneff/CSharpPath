using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _302.OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            int members = int.Parse(Console.ReadLine());
            List<Person> familyMembers = new List<Person>();

            for (int i = 0; i < members; i++)
            {
                string[] newMember = Console.ReadLine().Split();

                string name = newMember[0];
                int age = int.Parse(newMember[1]);

                Person person = new Person(name, age);
                familyMembers.Add(person);
            }

            Family newFamily = new Family(familyMembers);
            Person oldestMember = newFamily.GetOldestMember();
            Console.WriteLine("{0} {1}", oldestMember.Name, oldestMember.Age);
        }
    }

    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Family
    {
        public Family(List<Person> people)
        {
            People = people;
        }

        public List<Person> People { get; set; } = new List<Person>();

        public void AddNewFamilyMember(string name,int age)
        {
            People.Add(new Person(name, age));
        }
        public Person GetOldestMember()
        {
            var oldestPerson = People.OrderByDescending(x => x.Age).FirstOrDefault();
            return oldestPerson;
        }
    }
}