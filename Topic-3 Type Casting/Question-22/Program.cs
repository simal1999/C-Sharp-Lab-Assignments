using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_22
{
    internal class Program
    {
        static void Main(string[] args)
        {// write output for the below program
            char x= 'a';
            Console.WriteLine($"x value is {x}");
            int i = x;// here 'a' converts into ascii value so x contains 97 because 'a' ascii value is 97.
            Console.WriteLine($"i value is {i}");
            double d = x;//compiler converts int into double so the base type of is System.Double
            Console.WriteLine($"d value is {d}");
            Console.ReadLine();
        }
    }
}
