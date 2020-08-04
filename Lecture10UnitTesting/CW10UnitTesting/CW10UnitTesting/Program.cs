using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW10UnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(1, 5);
            var p2 = new Point(4, 1);
            var p3 = new Point(1,1);

            Triangle triangle = new Triangle(p1, p2, p3);
            triangle.Perimeter(p1, p2, p3);
            
            Console.WriteLine(triangle.Print());
        }
    }
}
