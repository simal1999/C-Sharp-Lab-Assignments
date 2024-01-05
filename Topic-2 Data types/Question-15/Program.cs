using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Question_15
{
    internal class Program
    {
        static void Main(string[] args)
        {//write a console program to store all unsigned datatypes and display to the user?
            byte age = 25;
            ushort pin = 4980;
            uint population = 1089320;
            ulong file_size = 1024000000;
            Console.WriteLine($"Your age is {age}");
            Console.WriteLine($"Your atmpin is {pin}");
            Console.WriteLine($"The number of population in this city {population}");
            Console.WriteLine($"This movie has a size of {file_size} bytes");
            Console.ReadLine();
        }
    }
}
