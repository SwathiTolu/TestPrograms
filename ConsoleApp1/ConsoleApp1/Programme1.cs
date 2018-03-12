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
            //7. program to multiply corresponding elements of two arrays of integers
            int[] array1 = new int[4];

            int[] array2 = new int[4];

            Console.WriteLine("Enter values in Array 1 = ");
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Enter values in Array 2 = ");
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = Convert.ToInt32(Console.ReadLine());

            }

            int[] array3 = new int[4];
            Console.Write("The values of new array are = { ");
            for (int i = 0; i < array1.Length; i++)
            {
                array3[i] = array1[i] * array2[i];
                Console.Write("{0} ", array3[i]);
            }
            Console.Write("}");

            Console.ReadKey();
        }
        public static void highLow()
        {
            //8. program to find the largest and lowest values from three integer values
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
            //9. program to create a new string of every other character (odd position) from the first position of a given string
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
            //10. program to compute the sum of all the elements of an array of integers.
            int[] array = new int[10];
            Console.WriteLine("Enter values of the array declared: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadLine();
            var result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                result = result + array[i];
            }
            Console.WriteLine("The sum all values in the array = {0}", result);
            Console.ReadKey();

        }

        public static void studentPassFail()
        {
            //11.program to compute student grades.
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

        public static void studentGradesPerSubject()
        {
            //12. program for student grades when subject marks are given
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

            Console.ReadLine();
        }

    }
}
