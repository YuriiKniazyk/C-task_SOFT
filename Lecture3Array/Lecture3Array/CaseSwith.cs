using System;

namespace Lecture3Array
{
    public class CaseSwith
    {
        public void PrintDrink()
        {
            Console.WriteLine("Please enter drink");
            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "coffee":
                    Console.WriteLine("Coffee 2$");
                    break;
                
                case "juice":
                    Console.WriteLine("Juice 5$");
                    break;

                case "tea":
                    Console.WriteLine("Tea 4$");
                    break;

                case "water":
                    Console.WriteLine("Water 1$");
                    break;
            }
            Console.WriteLine();
        }
    }
}