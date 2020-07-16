using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3Array
{
    class DivideBy3
    {
        public void CountDivide()
        {
            Console.WriteLine("Enter number 1");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int counter = 0;

            for (int i = num1; i <= num2; i++)
            {
                if (i % 3 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine($"Count number is {counter}");
            Console.WriteLine();
        }
    }
}
