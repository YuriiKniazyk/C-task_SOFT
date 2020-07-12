using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2Type
{
    class Program
    {
        static void Main(string[] args)
        {
            MonthAndDay monthAndDay = new MonthAndDay();
            monthAndDay.CheckMonthDay();

            DoubleNumber doubleNumber =new DoubleNumber();
            doubleNumber.GetNumber();

            HourTime time = new HourTime();
            time.WhatTime();

            TestCaseStatus status = new TestCaseStatus();
            status.GetStatus();

            RGB black = new RGB();
            RGB white = new RGB();
            black.GetRGB(0, 0, 0);
            white.GetRGB(255, 255, 255);

            Console.ReadKey();
        }
    }
}
