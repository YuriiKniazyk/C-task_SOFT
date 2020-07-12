using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2Type
{
    class RGB
    {
        RGBStructure rgbStructure = new RGBStructure();

        public void GetRGB(byte r, byte g, byte b)
        {
            rgbStructure.red = r;
            rgbStructure.blue = b;
            rgbStructure.green = g;

            Console.WriteLine(rgbStructure);
        }
    }
}
