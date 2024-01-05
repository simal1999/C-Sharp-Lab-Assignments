using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_23
{
    internal class Program
    {
        static void Main(string[] args)
        {// write a console program to accept employee number,nam eand salary and display to the user by using parsing?
            Console.WriteLine("Enter employee number: ");
            ulong eno=ulong.Parse(Console.ReadLine());
            Console.WriteLine("Enter employee name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter employee salary: ");
            double esal=double.Parse(Console.ReadLine());
            Console.WriteLine($"Employee number is {eno}");
            Console.WriteLine($"Employee name is {name}");
            Console.WriteLine($"Employee salary is {esal}");
            Console.ReadLine();
        }
    }
}
