using System;

namespace CW8
{
    public class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Person name is: {Name}");
        }
    }
}