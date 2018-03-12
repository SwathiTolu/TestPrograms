using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = input();
            if (x >= 1 && x <= 100)
            {
                if (x > 35)
                {
                    Console.WriteLine("Student is PASS");
                    if ( x > 60)
                    {
                        Console.WriteLine("Student got FIRST CLASS");
                    }
                    else if ( x > 50 && x < 60)
                    {
                        Console.WriteLine("Student got SECOND CLASS");
                    }
                    else
                        Console.WriteLine("Student got THIRD CLASS");
                }
                else
                {
                    Console.WriteLine("Student is FAIL");
                }
                

            }
            //Console.WriteLine("Enter the number ranges between 1 to 100");

            Console.ReadLine();
        }
        static int input()
        {
            Console.WriteLine("Enter Integer: ");
            int x = Convert.ToInt32(Console.ReadLine()); 
            if (x < 1 || x > 100)
            {
                input();
            }
            return x;

        }
    }
}
