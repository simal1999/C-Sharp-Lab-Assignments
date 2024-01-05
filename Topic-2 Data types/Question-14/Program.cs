using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_14
{
    internal class Program
    {
        static void Main(string[] args)
        {// write a console program to store all the signed data types and display to the user?
            sbyte lift = -2;
            short pages =300;
            int money_withdraw = -1000;
            long profit_or_loss=-1000000000;
            Console.WriteLine($"Entered floor is {lift}");
            Console.WriteLine($"This book has {pages} pages.");
            Console.WriteLine($"Money withdrawal amount in atm is {money_withdraw}");
            Console.WriteLine($"This movie has loss of {profit_or_loss} rupees");
            Console.ReadLine();
        }
    }
}
