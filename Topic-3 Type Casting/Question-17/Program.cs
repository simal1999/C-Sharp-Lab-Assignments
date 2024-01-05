using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_17
{
    internal class Program
    {
        static void Main(string[] args)
        {//write a cosnole program to accept age from the user store into variable and display to the user with proper datatype?
            Console.WriteLine("Enter your age");
            byte age=byte.Parse(Console.ReadLine());
            Console.WriteLine($"Your age is {age}");
            Console.ReadLine();
        }
    }
}
