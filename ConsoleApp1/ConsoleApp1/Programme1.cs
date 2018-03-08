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
        public static void swapNumbers()
        {
            //2. program to swap two numbers.
            Console.WriteLine("Enter 1st: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int z = x;
            x = y;
            y = z;
            Console.WriteLine("First Number: " + x);
            Console.WriteLine("Second Number: " + y);
            Console.ReadKey();
        }
        public static void multiplicationTable()
        {
            //3. program that takes a number as input and print its multiplication table.
            Console.WriteLine("Enter an Integer");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The multiplication table {x} is: ");
            for (int y = 0; y <= 10; y++)
            {
                Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
            }
            Console.ReadKey();
        }
        public static void tripleSum()
        {
            //4. program to compute the sum of two given integers, if two values are equal then return the triple of their sum.
            Console.WriteLine("Enter 1st: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd: ");
            int y = Convert.ToInt32(Console.ReadLine());
            if (x == y)
            {
                Console.WriteLine("Value:" + (3 * (x + y)));
            }
            else
            {
                Console.WriteLine("Value:" + (x + y));
            }
            Console.ReadKey();
        }
        public static void oddNumbers()
        {
            //5. program to print the odd numbers from 1 to 99.Prints one number per line.
            Console.WriteLine("Odd numbers list from 1 to 100: ");
            for (int x = 1; x < 100; x++)
            {
                if (x % 2 != 0)
                {
                    Console.WriteLine(x);
                }
            }
            Console.ReadKey();
        }

        public static void sumOfInteger()
        {
            //6. program and compute the sum of the digits of an integer.
            Console.WriteLine("Enter an Integer: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (n != 0)
            {
                sum = sum + (n % 10);
                n = n / 10;
            }
            Console.WriteLine("Sum of numbers in the given integer = " + sum);
            Console.ReadKey();
        }

        public static void multiplyArrays()
        {
            //program to multiply corresponding elements of two arrays of integers
            //to do
        }
        public static void highLow()
        {
            //7. program to find the largest and lowest values from three integer values
            Console.WriteLine("Enter 1st number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd number: ");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Largest Number = " + Math.Max(x, Math.Max(y, z)));
            Console.WriteLine("Lowest Number = " + Math.Min(x, Math.Min(y, z)));
            //Console.WriteLine("Largest Number = " + Math.Max(x, y, z));
            //Console.WriteLine("Lowest Number = " + Math.Min(x, y, z));
            Console.ReadKey();
        }

        public static void oddPossition()
        {
            //8. program to create a new string of every other character (odd position) from the first position of a given string
            Console.Write("Type something here : ");
            string name = Console.ReadLine();
            var result = string.Empty;
            for (var i = 0; i < name.Length; i++)
            {
                if (i % 2 == 0) result = result + name[i];
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
        public static void sumArrrayIntegers()
        {
            //program to compute the sum of all the elements of an array of integers.
            // dont know
        }

        public static void studentPassFail()
        {
            //program to compute student grades.
            int x = input();
            if (x >= 1 && x <= 100)
            {
                if (x > 35)
                {
                    Console.WriteLine("Student is PASS");
                    if (x > 60)
                    {
                        Console.WriteLine("Student got FIRST CLASS");
                    }
                    else if (x > 50 && x < 60)
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
