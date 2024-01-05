using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_13
{
    internal class Program
    {
        static void Main(string[] args)
        {//write a console program to accept phone number and atm pin of the user display to the user with user defined string with proper datatype?
            ulong phone = 9505445051;
            ushort pin = 4526;
            Console.WriteLine($"Your phone number is : {phone}");
            Console.WriteLine($"Your atm pin is      : {pin}");
            Console.ReadLine();
        }
    }
}
