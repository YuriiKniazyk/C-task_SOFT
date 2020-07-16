using System;

namespace Lecture3Array
{
    public class LeapYear
    {
        public void IsLeapYear()
        {
            Console.WriteLine("Enter the year");
            int year = int.Parse(Console.ReadLine());
            {
                if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                    Console.WriteLine("It's a leap year.");
                else
                    Console.WriteLine("It's not a leap year.");
            }
            Console.WriteLine();
        }
    }
}