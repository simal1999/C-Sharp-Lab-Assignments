using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_28
{
    internal class Program
    {
        static void Main(string[] args)
        {/*write a console program to accept 2 numbers and
          perform division operation and display the division result by simple if and handle zero error*/
            Console.WriteLine("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int b = int.Parse(Console.ReadLine());
            if (b==0)
            {
                Console.WriteLine("Enter other than zero.");
                b=int.Parse(Console.ReadLine());
            }// but here we will avoide zero error only for one time  
            int Result = a / b;
            Console.WriteLine($"The division rsult is {Result}");
            Console.ReadLine();
        }
    }
}
