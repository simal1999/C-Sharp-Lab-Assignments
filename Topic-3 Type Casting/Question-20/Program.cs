using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_20
{
    internal class Program
    {
        static void Main(string[] args)
        {//write a console program to accept name location and course of the user and display to the user with user defined strings?
            Console.WriteLine("Enter your name: ");
            string name =Console.ReadLine();
            Console.WriteLine("Enter your location: ");
            string location=Console.ReadLine();
            Console.WriteLine("Enter your course: ");
            string course=Console.ReadLine();
            Console.WriteLine($"Your name is     :{name}");
            Console.WriteLine($"Your location is :{location}");
            Console.WriteLine($"Your course is   :{course}");
            Console.ReadLine();
        }
    }
}
