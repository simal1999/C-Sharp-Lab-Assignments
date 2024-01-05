using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_18
{
    internal class Program
    {
        static void Main(string[] args)
        {//write a cosnole program to accept name,age and weight from the user store into variable and display to the user with proper datatype?
            Console.WriteLine("Enter your name: ");
            string name=Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            byte age=byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter your weight");
            float weight=float.Parse(Console.ReadLine());
            Console.WriteLine($"Your name is    :{name}");
            Console.WriteLine($"Your age is     :{age}");
            Console.WriteLine($"Your weight is  :{weight}");
            Console.ReadLine();
        }
    }
}
