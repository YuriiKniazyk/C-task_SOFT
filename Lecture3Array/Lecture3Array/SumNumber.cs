using System;

namespace Lecture3Array
{
    public class SumNumber
    {
        public void GetSum()
        {
            int sum = 0;

            Console.WriteLine("Please enter number");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            Console.WriteLine(sum);
            Console.WriteLine();
        }
    }
}