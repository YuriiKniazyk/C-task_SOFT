using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Enter a=");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter b=");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Sum {a} + {b} = {a + b}");
            Console.WriteLine($"Minus {a} - {b} = {a - b}");
            Console.WriteLine($"Multiply {a} * {b} = {a * b}");
            Console.WriteLine($"Divide {a} / {b} = {a / b}");

            //2
            Console.WriteLine("How are you?");
            string answer = Console.ReadLine();
            Console.WriteLine($"You are {answer}");

            //3
            Console.WriteLine("Enter char 1");
            string char1 = Console.ReadLine();

            Console.WriteLine("Enter char 2");
            string char2 = Console.ReadLine();

            Console.WriteLine("Enter char 3");
            string char3 = Console.ReadLine();

            Console.WriteLine($"You enter {char1}, {char2}, {char3}");

            //4
            Console.WriteLine("Enter number1");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number2");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if(number1 > 0 && number2 > 0)
            {
                Console.WriteLine("good");
            }
            else
            {
                Console.WriteLine("not good");
            }

            Console.ReadKey();
        }
    }
}
