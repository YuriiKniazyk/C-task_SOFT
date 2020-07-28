using System;

namespace CW8
{
    public class Developer : Staff
    {
        public string Skills { get; set; }

        public Developer(string name, string salary, string skills) : base(name, salary)
        {
            Skills = skills;
        }

        public override void Print()
        {
            Console.WriteLine($"Developer name is: {Name}, this is {Salary} and this skills is {Skills}");
        }
    }
}