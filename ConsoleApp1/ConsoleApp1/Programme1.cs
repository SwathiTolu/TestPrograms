using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Programme1
    {

        public static void multiplication()
        {
            //1. program to print the output of multiplication of three numbers, which will be entered by the user.
            Console.WriteLine("Enter 1st: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3nd: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Value (a * b * c) = " + a * b * c);
            Console.ReadKey();
        }
       
    }
}
