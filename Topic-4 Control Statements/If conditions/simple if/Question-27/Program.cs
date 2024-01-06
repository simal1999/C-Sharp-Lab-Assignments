using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Question_27
{
    internal class Program
    {
        static void Main(string[] args)
        {/*write a console program to accept 2 numbers and
          perform division operation and display the division result*/
            Console.WriteLine("Enter first number: ");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int b=int.Parse(Console.ReadLine());
            int Result = a / b;
            Console.WriteLine($"The division rsult is {Result}");
            Console.ReadLine();
        }
    }
}
