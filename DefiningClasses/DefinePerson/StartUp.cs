using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var family = new Family();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                var command = Console.ReadLine().Split();
                string name = command[0];
                int age = int.Parse(command[1]);
                var person = new Person(name, age);
                family.AddMembers(person);
            }

            family.ReturnOldestMembers();
        }
    }
}
