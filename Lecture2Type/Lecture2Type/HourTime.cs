
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2Type
{
    class HourTime
    {
        public void WhatTime()
        {
            Console.WriteLine("Please enter hour: ");

            bool isValid = Int32.TryParse(Console.ReadLine(), out var time);

            while (!isValid)
            {
                Console.WriteLine("Invalid time!!! Try again! Hour=");
                isValid = Int32.TryParse(Console.ReadLine(), out time);
            }

            if (isValid)
            {
                string answer = (time > 0 && time <= 6) ? "Good night!" : (time > 6 && time <= 12) ? "Good morning!" :
                    (time > 12 && time <= 18) ? "Good afternoon" :
                        (time > 18 && time <= 24) ? "Good evening" :
                            "You have entered an incorrect hour!!";
                Console.WriteLine($"{answer}");
                Console.WriteLine();
            }
        }
    }
}
