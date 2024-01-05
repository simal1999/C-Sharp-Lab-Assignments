using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_21
{
    internal class Program
    {
        static void Main(string[] args)
        {//Write a console program for implicit type casting from int to long and double 
            int a = 1000;// here a is int datatype
            long b = a;//compiler automatically converts int to long,here b is long a is int  
            Double c = b;//compiler automatically converts long to double,here c is double a is int   
            Console.WriteLine($"The type of a is {a.GetType()}");
            Console.WriteLine($"The type of b is {b.GetType()}");
            Console.WriteLine($"The type of c is {c.GetType()}");
            Console.ReadLine();
        }
    }
}
