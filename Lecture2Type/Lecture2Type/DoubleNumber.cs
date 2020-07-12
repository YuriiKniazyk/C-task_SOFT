using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2Type
{
    class DoubleNumber
    {
        public void GetNumber()
        {
            Console.WriteLine("Please enter double number: ");

            bool isValid = double.TryParse(Console.ReadLine(), out var number);

            while (!isValid)
            {
                Console.WriteLine("Invalid number!!! Try again! Number=");
                isValid = double.TryParse(Console.ReadLine(), out number);
            }

            if (isValid)
            {
                var newNumber1 = (int)(number * 10 % 10);
                var newNumber2 = (int)(number * 100 % 10);

                Console.WriteLine($"Sum {newNumber1} & {newNumber2} = {newNumber1 + newNumber2}");
            }
            Console.WriteLine();
        }
    }
}
