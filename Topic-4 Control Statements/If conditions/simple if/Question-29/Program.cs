using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_29
{
    internal class Program
    {
        static void Main(string[] args)
        {//write a console program to accept 2 numbers store i and j display which is greater by using simple if.
            Console.WriteLine("Enter first number: ");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int j = int.Parse(Console.ReadLine());
            // here control will check all the conditons weather one condition is true 
            if (i>j)
            {
                Console.WriteLine($"{i} is greater than {j}");
            }
            if (i < j)
            {
                Console.WriteLine($"{j} is greater than {i}");
            }
            if (i == j)
            {
                Console.WriteLine($"Both are equal");
            }
            Console.ReadLine();
        }
    }
}
