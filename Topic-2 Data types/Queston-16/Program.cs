using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queston_16
{
    internal class Program
    {
        static void Main(string[] args)
        {// write a console program to store all the floating point datatype and display to the user?
            float marks = 95.3f;
            double salary =39480.8676756;
            decimal currency = 5.2938928099m;
            Console.WriteLine($"stdent marks is {marks}");
            Console.WriteLine($"Employee salary is {salary}");
            Console.WriteLine($"today bitcoin rate fallen to {currency}");
            Console.ReadLine();
        }
    }
}
