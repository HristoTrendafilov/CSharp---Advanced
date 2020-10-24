using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var person1 = new Person();
            var person2 = new Person(2);
            var person3 = new Person("Pesho", 30);
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
                this.Age = age;
            }
            public Person(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }

            public string Name
            {
                get { return this.name; }
                set { this.name = value; }
            }
            public int Age
            {
                get { return this.age; }
                set { this.age = value; }
            }
        }
    }
}
