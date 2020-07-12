using System;

namespace Lecture2Type
{
    public class MonthAndDay
    {
        public void CheckMonthDay()
        {
            Console.WriteLine("Please enter months: ");
            int month = Convert.ToInt32(Console.ReadLine());
            string answerMonth = (month >=1 && month <= 12) ? $"Your months number is {month}" : "This month not exist!!";

            Console.WriteLine($"{answerMonth}");
            Console.WriteLine("Please enter day: ");

            int day = Convert.ToInt32(Console.ReadLine());
            string answerDay = (day >= 1 && day <= 31) ? $"Your day number is {day}" : "This day not exist!!";
            Console.WriteLine($"{answerDay}");

            if (month == 2)
            {
                if (day > 28)
                {
                    Console.WriteLine("This day not exist in this months!!");

                }
                else
                {
                    Console.WriteLine("All is good");
                }
            }
            Console.WriteLine();
        }
    }
}