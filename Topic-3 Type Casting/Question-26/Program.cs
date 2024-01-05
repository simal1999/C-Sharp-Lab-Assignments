using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_26
{
    internal class Program
    {
        static void Main(string[] args)
        {/*write a console program to accept student name and accept student 3 subjects marks i.e m1,m2,m3 and calculate total marks and average marks 
           finally display to the user total marks , average marks with student name */
            Console.WriteLine("Enter student name:");
            string name=Console.ReadLine();
            Console.WriteLine("Enter first subject marks:");
            byte m1=Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter second subject marks:");
            byte m2=Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter third subject marks:");
            byte m3=byte.Parse(Console.ReadLine());
            byte total = (byte)(m1 + m2 + m3);// if we do arthimatic operations on  byte it upgraded to int so we explicitly converts into byte .
            float average = (total / 3);
            Console.WriteLine($"{name} total marks is  :{total}");
            Console.WriteLine($"{name} average marks is:{average}");
            Console.ReadLine();
        }
    }
}
