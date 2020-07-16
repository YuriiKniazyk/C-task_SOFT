using System;

namespace Lecture3Array
{
    public class SymbolTwo
    {
        public void PrintSymbol()
        {
            Console.WriteLine("Please enter string: ");
            string str = Console.ReadLine();

            for (int i=0;  i < str.Length; i++)
            {   
                if(i % 2 != 0) Console.WriteLine(str[i]);
            }

            Console.WriteLine();
        }
    }
}