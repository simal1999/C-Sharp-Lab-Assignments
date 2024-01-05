using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_25
{
    internal class Program
    {
        static void Main(string[] args)
        {// write a console program to accept employee number, name, salary and display to the user by using converting?
            Console.WriteLine("Enter employee number");
            ulong eno =Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("Enter employee name");
            string name=Console.ReadLine();
            Console.WriteLine("Enter employee salary");
            double esal=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Employee number is {eno}");
            Console.WriteLine($"Employee name is {name}");
            Console.WriteLine($"Employee salary is {esal}");
            Console.ReadLine();
        }
    }
}
