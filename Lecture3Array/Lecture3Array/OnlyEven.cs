using System;

namespace Lecture3Array
{
    public class OnlyEven
    {
        public void IsEven()
        {
            Console.WriteLine("Please enter number");
            int number = Convert.ToInt32(Console.ReadLine());

            string answer = "";
            while (number > 0)
            {
                int num = number % 10;
                number /= 10;

                if (num % 2 == 0)
                {
                    answer = "No";
                    break;
                }
                else
                {
                    answer = "yes";
                }
            }
            Console.WriteLine(answer);
        }
    }
}