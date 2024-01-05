using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_24
{
    internal class Program
    {
        static void Main(string[] args)
        {// Write a console program to accept salary from the user store into variable and display to the user with proper datatype by using Converting?
            Console.WriteLine("Enter your salary: ");
            double esal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Your salary is {esal}");
            Console.ReadLine();
        }
    }
}
