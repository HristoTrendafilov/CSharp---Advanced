using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> familyMembers;
        public Family()
        {
            this.familyMembers = new List<Person>();
        }

        public void AddMembers(Person person)
        {
            this.familyMembers.Add(person);
        }

        public void ReturnOldestMembers()
        {
            var oldestFamilyMembers = new List<Person>();
            for (int i = 0; i < familyMembers.Count; i++)
            {
                if (familyMembers[i].Age > 30)
                {
                    oldestFamilyMembers.Add(familyMembers[i]);
                }
            }
            foreach (var member in familyMembers.OrderBy(x=>x.Name))
            {
                if (member.Age > 30)
                {
                   Console.WriteLine($"{member.Name} - {member.Age}");
                }

            }
            
        }
    }
}
