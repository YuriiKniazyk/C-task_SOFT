using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> list = new List<int> { 2, 5, -10, 35, 1, 12, -7, -15, 15, 17 };

                Console.WriteLine("Negative number from list");
                IEnumerable<int> negative = list.Where(i => i < 0);
                foreach (var i in negative)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine("Negative positive from list");
                IEnumerable<int> positive = list.Where(i => i > 0);
                foreach (var i in positive)
                {
                    Console.WriteLine(i);
                }

                int minElement = list.Min(i => i);
                int maxElement = list.Max(i => i);
                Console.WriteLine($"min element {minElement}");
                Console.WriteLine($"min element {maxElement}");

                int sum = list.Sum(i => i + i);
                Console.WriteLine($"sum element {sum}");

                double avg = list.Average();
                int minArray = list.Where(i => i < avg).Max();

                Console.WriteLine($"Avg= {avg}, min element avg: {minArray}");


                IEnumerable<int> sort= list.OrderBy(i => i);
                Console.WriteLine("Sort array: ");
                foreach (var i in sort)
                {
                    Console.WriteLine(i);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
