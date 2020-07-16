using System;
using System.Collections.Generic;

namespace Lecture3Array
{
    public class AverageCount
    {
        public void GetAverage()
        {
            int count = 0;
            int sum = 0;
            int n;

            Console.WriteLine("Please enter numbers");

            List<int> userInts = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                string userValue = Console.ReadLine();
                if (int.TryParse(userValue, out int userInt))
                {
                    userInts.Add(userInt);
                }
            }
            Console.WriteLine(userInts);
        }
    }
}