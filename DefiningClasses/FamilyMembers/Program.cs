using System;
using System.Collections.Generic;
using System.Linq;
namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var counter = int.Parse(Console.ReadLine());
            var family = new Family();
            var familyMembers = new List<Person>();

            for (int i = 0; i < counter; i++)
            {
                var command = Console.ReadLine().Split();
                var person = new Person();
                person.Age = int.Parse(command[1]);
                person.Name = command[0];
                familyMembers.Add(person);
            }
            var personWithMaxAge = family.ReturnOldestMember();
        }
        public class Person
        {
            private string name;
            private int age;
            public Person()
            {
                this.Name = "No name";
                this.Age = 1;
            }
            public Person(int age) : this()
            {
                Age = age;
            }
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
            public List<string> FamilyMembers { get; set; }
            public void AddMember(string name)
            {
                FamilyMembers.Add(name);
            }
            public Person ReturnOldestMember(List<Person> familyMembers)
            {
                var name = string.Empty;
                var age = int.MinValue;

                for (int i = 0; i < familyMembers.Count; i++)
                {
                    if (familyMembers[i].Age > age)
                    {
                        age = familyMembers[i].Age;
                        name = familyMembers[i].Name;
                    }
                }

                return Console.WriteLine($"{name} {age}");
            }
        }
    }
}
