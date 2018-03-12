using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[6] { 64, 55, 33, 44, 65, 66 };

            bool StudentPassed = true;
            for (int i = 0; i < 6; i++)
            {
                int subjectMark = myArray[i];


                if (subjectMark > 35)
                {
                    StudentPassed = true;

                }
                else
                {
                    StudentPassed = false;
                    break;
                }


            }

            if (StudentPassed)
            {
                Console.WriteLine("Student Passed");
            }
            else
            {
                Console.WriteLine("Student Failed");
            }

            //int x = input();
            //if (x >= 1 && x <= 100)
            //{
            //    if (x > 35)
            //    {
            //        Console.WriteLine("Student is PASS");
            //        if (x > 60)
            //        {
            //            Console.WriteLine("Student got FIRST CLASS");
            //        }
            //        else if (x > 50 && x < 60)
            //        {
            //            Console.WriteLine("Student got SECOND CLASS");
            //        }
            //        else
            //            Console.WriteLine("Student got THIRD CLASS");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Student is FAIL");
            //    }


            // }
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
