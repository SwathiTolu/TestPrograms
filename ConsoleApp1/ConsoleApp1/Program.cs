﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write 'Hello World!' program
            Console.WriteLine("Hello World");
            Console.ReadKey();

            Programme1.multiplication();

        }



        ////2. program to swap two numbers.
        //Console.WriteLine("Enter 1st: ");
        //int x = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter 2nd: ");
        //int y = Convert.ToInt32(Console.ReadLine());
        //int z = x;
        //x = y;
        //y = z;
        //Console.WriteLine("First Number: "  + x);
        //Console.WriteLine("Second Number: " + y);
        //Console.ReadKey();

        ////3. program that takes a number as input and print its multiplication table.
        //Console.WriteLine("Enter an Integer");
        //int x = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("The multiplication table {x} is: ");
        //for(int y = 0; y <= 10; y++)
        //{
        //    Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
        //}
        //Console.ReadKey();

        ////4. program to compute the sum of two given integers, if two values are equal then return the triple of their sum.
        //Console.WriteLine("Enter 1st: ");
        //int x = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter 2nd: ");
        //int y = Convert.ToInt32(Console.ReadLine());
        //if (x == y)
        //{
        //    Console.WriteLine("Value:" + (3 * (x + y)));
        //}
        //else
        //{
        //    Console.WriteLine("Value:" + (x + y));
        //}
        //Console.ReadKey();

        ////5. program to print the odd numbers from 1 to 99. Prints one number per line.
        //Console.WriteLine("Odd numbers list from 1 to 100: ");
        //for (int x = 1; x < 100; x++)
        //{
        //    if (x % 2 != 0)
        //    {
        //        Console.WriteLine(x);
        //    }
        //}
        //Console.ReadKey();

        ////6. program and compute the sum of the digits of an integer.
        //Console.WriteLine("Enter an Integer: ");
        //int n = Convert.ToInt32(Console.ReadLine());
        //int sum = 0;
        //while (n != 0)
        //{
        //    sum = sum + (n % 10);
        //    n = n / 10;
        //}
        //Console.WriteLine("Sum of numbers in the given integer = " + sum);
        //Console.ReadKey();

        //7. program to multiply corresponding elements of two arrays of integers
        //int[] array1 = new array1[5];


        ////8. program to find the largest and lowest values from three integer values
        //Console.WriteLine("Enter 1st number: ");
        //int x = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter 2nd number: ");
        //int y = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter 3rd number: ");
        //int z = Convert.ToInt32(Console.ReadLine());

        ////Console.WriteLine("Largest Number = " + Math.Max(x, Math.Max(y, z)));
        ////Console.WriteLine("Lowest Number = " + Math.Min(x, Math.Min(y, z)));
        //Console.WriteLine("Largest Number = " + Math.Max(x, y, z));
        //Console.WriteLine("Lowest Number = " + Math.Min(x, y, z));
        //Console.ReadKey();


        ////9. program to create a new string of every other character (odd position) from the first position of a given string
        //Console.Write("Type something here : ");
        //string name = Console.ReadLine();
        //var result = string.Empty;
        //for (var i = 0; i < name.Length; i++)
        //{
        //    if (i % 2 == 0) result = result + name[i];
        //}
        //Console.WriteLine(result);
        //Console.ReadKey();

        //10. program to compute the sum of all the elements of an array of integers.
        // dont know






    
    }
}