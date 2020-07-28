using System;

namespace CW8
{
    public class Teacher : Staff
    {
        public string Subject { get; set; }

        public Teacher(string name, string salary, string subject) : base(name, salary)
        {
            Subject = subject;
        }

        public override void Print()
        {
            Console.WriteLine($"Teacher name is: {Name}, this is {Salary} and this learn is {Subject}");
        }
    }
}