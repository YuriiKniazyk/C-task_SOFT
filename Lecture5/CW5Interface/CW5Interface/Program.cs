using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW5Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bird> birds = new List<Bird>
            {
                new Bird("zozulya", true),
                new Bird("straus", false),
                new Bird("kivi", false),
                new Bird("ka4ka", true),
                new Bird("kyrka", true),
            };

            birds.Add(new Bird("daxa", false));
            birds.ForEach(item => Console.WriteLine(item.Fly(item.CanFly)));
            Console.WriteLine();

            List<Plane> planes = new List<Plane>
            {
                new Plane("an", true),
                new Plane("tu", true),
                new Plane("ne", false),
                new Plane("za", true),
                new Plane("ha", false)
            };

            planes.Add(new Plane("qw", true));
            planes.ForEach(item => Console.WriteLine(item.Fly(item.HighFly)));
            Console.WriteLine();




            List<int> myColl = new List<int>() {2, 4, 5, 10, -10, -10, 5, 25, 30, 5, 12, 23, 11, 11, 1};

            for (int i = 0; i < myColl.Count; i++)
            {
                if (myColl[i] == -10)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("============================================");

            for (int i = 0; i < myColl.Count; i++)
            {
                if (myColl[i] > 20)
                {
                    myColl.RemoveAt(i);
                    i--;
                }
            }
            
            foreach (var VARIABLE in myColl)
            {
                Console.WriteLine(VARIABLE);
            }

            Console.WriteLine("============================================");
            myColl.Insert(2, 1);
            myColl.Insert(8, -3);
            myColl.Insert(5, -4);
            foreach (var VARIABLE in myColl)
            {
                Console.WriteLine(VARIABLE);
            }
            Console.WriteLine("============================================");

            myColl.Sort();
            foreach (var VARIABLE in myColl)
            {
                Console.WriteLine(VARIABLE);
            }
            Console.WriteLine("============================================");

            Console.ReadKey();
        }
    }
}
