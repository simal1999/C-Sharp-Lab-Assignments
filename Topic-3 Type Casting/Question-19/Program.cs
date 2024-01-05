using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_19
{
    internal class Program
    {
        static void Main(string[] args)
        {// write a console program to know the base type and size of a all datatype?
            //these are used in converting  to convert so learn basetype of the data type.
                               //signed numeric datatypes
            Console.WriteLine($"The base type of byte is   :{typeof(byte)}");
            Console.WriteLine($"The size of byte is        :{sizeof(byte)}");
            Console.WriteLine($"The base type of short is  :{typeof(short)}");
            Console.WriteLine($"The size of short is       :{sizeof(short)}");
            Console.WriteLine($"The base type of int is    :{typeof(int)}");
            Console.WriteLine($"The size of int is         :{sizeof(int)}");
            Console.WriteLine($"The base type of long is   :{typeof(long)}");
            Console.WriteLine($"The size of long is        :{sizeof(long)}");
                               //unsigned numeric datatypes
            Console.WriteLine($"The base type of sbyte is  :{typeof(sbyte)}");
            Console.WriteLine($"The size of byte is        :{sizeof(sbyte)}");
            Console.WriteLine($"The base type of ushort is :{typeof(ushort)}");
            Console.WriteLine($"The size of short is       :{sizeof(short)}");
            Console.WriteLine($"The base type of uint is   :{typeof(uint)}");
            Console.WriteLine($"The size of uint is        :{sizeof(int)}");
            Console.WriteLine($"The base type of ulong is  :{typeof(ulong)}");
            Console.WriteLine($"The size of long is        :{sizeof(long)}");
                               // floating point datatypes
            Console.WriteLine($"The base type of float is  :{typeof(float)}");
            Console.WriteLine($"The size of float is       :{sizeof(float)}");
            Console.WriteLine($"The base type of double is :{typeof(double)}");
            Console.WriteLine($"The size of double is      :{sizeof(double)}");
            Console.WriteLine($"The base type of decimal is:{typeof(decimal)}");
            Console.WriteLine($"The size of decimal is     :{sizeof(decimal)}");
                               // character datatypes
            Console.WriteLine($"The base type of char is   :{typeof(char)}");
            Console.WriteLine($"The size of char is        :{sizeof(char)}");
                               // logical datatypes
            Console.WriteLine($"The base type of bool is   :{typeof(bool)}");
            Console.WriteLine($"The size of bool is        :{sizeof(bool)}");
                               // general datatypes
            Console.WriteLine($"The base type of string is :{typeof(string)}");
                               //there is no size for the string
            Console.ReadLine();

        }
    }
}
