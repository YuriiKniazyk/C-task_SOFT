using System;

namespace CW8
{
    public class Staff : Person
    {
        public string Salary { get; set; }

        public Staff(string name, string salary) : base(name)
        {
            Salary = salary;
        }

        public override void Print()
        {
            Console.WriteLine($"Staff name is: {Name} and this is {Salary}");
        }
    }
}